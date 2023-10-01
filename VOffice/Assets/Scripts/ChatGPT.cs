using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using Amazon.Polly;
using System.Threading.Tasks;
using Amazon;
using Amazon.Polly.Model;
using UnityEngine;
using Amazon.Runtime;
using UnityEngine.Networking;

namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        [SerializeField] private InputField inputField;
        [SerializeField] private Button button;
        [SerializeField] private ScrollRect scroll;
        [SerializeField] private AudioSource audioSource;
        
        [SerializeField] private RectTransform sent;
        [SerializeField] private RectTransform received;

        private float height;
        private OpenAIApi openai = new OpenAIApi("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");

        private List<ChatMessage> messages = new List<ChatMessage>();
        private string prompt = "Act as a random stranger in a chat room and reply to the questions. Don't break character. Don't ever mention that you are an AI model.";

        private void Start()
        {
            // button.onClick.AddListener(SendReply);
            SendReply();
        }

        private void AppendMessage(ChatMessage message)
        {
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

            var item = Instantiate(message.Role == "user" ? sent : received, scroll.content);
            item.GetChild(0).GetChild(0).GetComponent<Text>().text = message.Content;
            item.anchoredPosition = new Vector2(0, -height);
            LayoutRebuilder.ForceRebuildLayoutImmediate(item);
            height += item.sizeDelta.y;
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
            scroll.verticalNormalizedPosition = 0;
        }

        private async void SendReply()
        {
            var newMessage = new ChatMessage()
            {
                Role = "user",
                Content = "hello world"
                // Content = inputField.text
            };
            
            AppendMessage(newMessage);

            if (messages.Count == 0) newMessage.Content = prompt + "\n" + inputField.text; 
            
            messages.Add(newMessage);
            
            button.enabled = false;
            inputField.text = "";
            inputField.enabled = false;
            
            // Complete the instruction
            var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
            {
                Model = "gpt-3.5-turbo-0613",
                Messages = messages
            });

            if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            {
                var message = completionResponse.Choices[0].Message;
                message.Content = message.Content.Trim();
                polly(message.Content);
                messages.Add(message);
                AppendMessage(message);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }

            button.enabled = true;
            inputField.enabled = true;
        }

        private async void polly(string text)
    {
        var credentials = new BasicAWSCredentials("AKIARA75K6WI6CI3YFSJ", "i2iGs7JYb67ZT82r+MyCOh48S3D+KpQpu7J9c1Rz");
        var client = new AmazonPollyClient(credentials, RegionEndpoint.USEast1);
        var request = new SynthesizeSpeechRequest()
        {
            Text = text,
            Engine = Engine.Neural,
            VoiceId = VoiceId.Aria,
            OutputFormat = OutputFormat.Mp3
        };
        var response = await client.SynthesizeSpeechAsync(request); 
        
        WriteIntoFile (response.AudioStream);
        
        using (var www = UnityWebRequestMultimedia.GetAudioClip($"{Application.persistentDataPath}/audio.mp3", AudioType.MPEG)) {
            var op = www.SendWebRequest();
            while (!op.isDone) await Task.Yield();
            var clip = DownloadHandlerAudioClip.GetContent(www);
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    private void WriteIntoFile (Stream stream) 
    {
        using (var fileStream = new FileStream ($"{Application.persistentDataPath}/audio.mp3", FileMode.Create)) {
            byte[] buffer = new byte[8 * 1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0) {
                fileStream.Write(buffer, 0, bytesRead);
            }
        }
    }
    }
}
