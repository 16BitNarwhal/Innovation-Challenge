using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon.Polly;
using System.Threading.Tasks;
using Amazon;
using Amazon.Polly.Model;
using UnityEngine;
using Amazon.Runtime;
using UnityEngine.Networking;

public class TextToSpeech : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    private async void Start()
    {
        var credentials = new BasicAWSCredentials("AKIARA75K6WI6CI3YFSJ", "i2iGs7JYb67ZT82r+MyCOh48S3D+KpQpu7J9c1Rz");
        var client = new AmazonPollyClient(credentials, RegionEndpoint.USEast1);
        var request = new SynthesizeSpeechRequest()
        {
            Text = "Testing Amazon Polly, in Unity!",
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
