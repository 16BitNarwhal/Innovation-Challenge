using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        private OpenAIApi openai = new OpenAIApi("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");

        private List<ChatMessage> messages = new List<ChatMessage>();
        private string prompt = "Act as a random stranger in a chat room and reply to the questions. Don't break character. Don't ever mention that you are an AI model.";


        public async void GetMessage(string userMessage)
        {
              Debug.Log("Helloooo");
              var newMessage = new ChatMessage()
              {
                  Role = "user",
                  Content = userMessage
              };
            
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
                
                  messages.Add(message);
              }
              else
              {
                  Debug.LogWarning("No text was generated from this prompt.");
              }

              return message;
        }
   }
}
