using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using System;
using Amazon.Runtime.Internal;
using Amazon.Polly;
using System.Threading.Tasks;
using Amazon;
using Amazon.Polly.Model;
using Amazon.Runtime;
using UnityEngine.Networking;
using System.Reflection;

namespace OpenAI
{
    public class Advisor : MonoBehaviour
    {
        [SerializeField] private AudioSource clip2;
        [SerializeField] private Button recordButton;
        [SerializeField] private TextMeshProUGUI finalResponse;
        [SerializeField] private Animator animator;
        private String t2t;
        
        private readonly string fileName = "output.wav";
        private readonly int duration = 7;
        private OpenAIApi openai = new OpenAIApi("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");
        private List<ChatMessage> messages = new List<ChatMessage>();
        public int advisorNumber;
        private string prompt;

        private bool recording = false;

        void Start(){
            recordButton.GetComponent<Image>().color = Color.green;
            if (animator != null) animator.SetBool("talking", false);
        }

        private async void polly(string text)
        {
            var voiceStyle = VoiceId.Amy;
            if(advisorNumber == 1){
                voiceStyle = VoiceId.Arthur;
            } else if(advisorNumber==2){
                voiceStyle = VoiceId.Matthew;
            } else if(advisorNumber==3){
                voiceStyle = VoiceId.Emma;
            } else if(advisorNumber==4){
                voiceStyle = VoiceId.Amy;
            }
            var credentials = new BasicAWSCredentials("AKIARA75K6WI6CI3YFSJ", "i2iGs7JYb67ZT82r+MyCOh48S3D+KpQpu7J9c1Rz");
            var client = new AmazonPollyClient(credentials, RegionEndpoint.USEast1);
            
            var request = new SynthesizeSpeechRequest()
            {
                Text = text,
                Engine = Engine.Neural,
                VoiceId = voiceStyle,
                OutputFormat = OutputFormat.Mp3
            };
            var response = await client.SynthesizeSpeechAsync(request); 
            WriteIntoFile(response.AudioStream);

            using (var www = UnityWebRequestMultimedia.GetAudioClip($"{Application.persistentDataPath}/audio.mp3", AudioType.MPEG)) {
                
                var op = www.SendWebRequest();
                while (!op.isDone) await Task.Yield();
                clip2.clip = DownloadHandlerAudioClip.GetContent(www);
                clip2.Play();
                if (animator != null) {
                    animator.SetBool("talking", true);
                    while (clip2.isPlaying) {
                        await Task.Yield();
                    }
                    animator.SetBool("talking", false);
                }
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

        private async void SendReply(string userMessage)
        {
            if(advisorNumber ==1){
                prompt = "you are a finance advisor. do not mention that you are an ai model. you provide accurate information on how entrepreneurs and business can manage their personal finances and grow financially. my question is:";
            } else if(advisorNumber==2){
                prompt = "you are a marketing advisor. do not mention that you are an ai model. you provide accurate information on how to create marketing campaigns, promote products, and get social media traction. my question is:You are an entrepreneurship advisor.";
            } else if(advisorNumber==3){
                prompt = "you are a venture capitalist advisor. do not mention that you are an ai model. you provide accurate information on who to raise venture capital, whether or not entrepreneurs should take funding deals, and anything else related to venture capital. my question is:";
            } else if(advisorNumber==4){
                prompt = "you are a tech advisor. do not mention that you are an ai model. you provide accurate information on how to create software, scale technical systems, and implement technical ideas. my question is:";
            }
            var newMessage = new ChatMessage()
            {
                Role = "user",
                Content = userMessage
            };
            

            if (messages.Count == 0) newMessage.Content = prompt + "\n" + userMessage; 
            
            messages.Add(newMessage);
            
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
                t2t = message.Content;
                finalResponse.text = t2t;
                finalResponse.GetComponent<typewriterUI>().animateText();
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }
        }
        
        public void ToggleRecording()
        {
            if (!recording) {
                recordButton.GetComponent<Image>().color = Color.red;
                recording = true;
                recordButton.GetComponentInChildren<TextMeshProUGUI>().text = "Stop Recording";
                StartRecording();
            } else {
                recordButton.GetComponent<Image>().color = Color.green;
                recording = false;
                recordButton.GetComponentInChildren<TextMeshProUGUI>().text = "Start Recording";
                EndRecording();
            }
        }

        public void StartRecording()
        {
            if (clip2 == null) clip2 = GetComponent<AudioSource>();
            clip2.clip = Microphone.Start(null, false,duration, 44100);
            // clip2.Play();
            while (!(Microphone.GetPosition(null) > 0)) { }
        }

        public async void EndRecording()
        {
            Microphone.End(null);
            byte[] data = SaveWav.Save(fileName, clip2.clip);
            
            var req = new CreateAudioTranslationRequest()
            {
                FileData = new FileData() {Data = data, Name = "audio.wav"},
                // File = Application.persistentDataPath + "/" + fileName,
                Model = "whisper-1",
            };
            var s2t = await openai.CreateAudioTranslation(req);
            SendReply(s2t.Text);
        }
    }
}