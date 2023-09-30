using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGPT : MonoBehaviour
{
    // Reference to the GameObject with ScriptA
    public GameObject chatGPT;

    // Reference to the ScriptA component
    private ChatGPT ChatGPTComponent;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLOOOOOOOO");  
        // Get the ScriptA component from the GameObject with ScriptA
        ChatGPTComponent = chatGPT.GetComponent<ChatGPT>();

        if (ChatGPTComponent != null)
        {
            // Call the method in ScriptA
            res = ChatGPTComponent.GetMessage("What is your name");
        }
        else
        {
            Debug.LogError("ScriptA component not found!");
        }
        Debug.Log("response" + res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
