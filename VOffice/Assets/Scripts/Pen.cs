using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Pen : MonoBehaviour
{
    [Header("Pen Properties")]
    public Transform tip;
    public Material drawingMaterial;
    public Material tipMaterial;
    [Range(0.01f, 0.1f)]
    public float penWidth = 0.01f;
    public Color[] penColors;

    [Header("Hands & Grabbable")]
    public XRGrabInteractable grabbable;
    public InputActionReference drawReference = null;
    public InputActionReference colorReference = null;

    private LineRenderer currentDrawing;
    private int index;
    private int currentColorIndex;

    private void Start()
    {
        currentColorIndex = 0;
        tipMaterial.color = penColors[currentColorIndex];
    }

    float prevColor = 0; // horrible naming conventions I know, but I'm running at 9AM on 2 hours of sleep
    // I have school tmrw pray for me plsss
    private void Update()
    {
        float drawing = drawReference.action.ReadValue<float>();
        float color = colorReference.action.ReadValue<float>();
        bool isGrabbed = grabbable.isSelected;
        // Debug.Log("Drawing: " + drawing + " isGrabbed: " + isGrabbed);
        if (isGrabbed && drawing>0.5f) {
            Draw();
        }
        else if (currentDrawing != null)
        {
            currentDrawing = null;
        }
        else if (color>0.5f && prevColor<0.5f) 
        {
            SwitchColor();
        }
        prevColor = color;
    }

    private void Draw()
    {
        if (currentDrawing == null)
        {
            index = 0;
            currentDrawing = new GameObject().AddComponent<LineRenderer>();
            currentDrawing.material = drawingMaterial;
            currentDrawing.startColor = currentDrawing.endColor = penColors[currentColorIndex];
            currentDrawing.startWidth = currentDrawing.endWidth = penWidth;
            currentDrawing.positionCount = 1;
            currentDrawing.SetPosition(0, tip.position);
        }
        else
        {
            var currentPos = currentDrawing.GetPosition(index);
            if (Vector3.Distance(currentPos, tip.position) > 0.005f)
            {
                index++;
                currentDrawing.positionCount = index + 1;
                currentDrawing.SetPosition(index, tip.position);
                Debug.Log(tip.position);
            }
        }
    }

    private void SwitchColor()
    {
        if (currentColorIndex == penColors.Length - 1)
        {
            currentColorIndex = 0;
        }
        else
        {
            currentColorIndex++;
        }
        tipMaterial.color = penColors[currentColorIndex];
    }
}