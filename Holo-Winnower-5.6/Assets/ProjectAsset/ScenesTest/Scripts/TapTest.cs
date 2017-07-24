using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class TapTest : MonoBehaviour, IInputClickHandler
{
    public GameObject cube;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        cube.GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0, 0.5F), UnityEngine.Random.Range(0, 0.5F), UnityEngine.Random.Range(0, 0.5F));
    }
}
