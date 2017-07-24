using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class GazeEventTest : MonoBehaviour, IFocusable
{
    public void OnFocusEnter()
    {
        this.GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0, 1F), UnityEngine.Random.Range(0, 1F), UnityEngine.Random.Range(0, 1F));
    }

    public void OnFocusExit()
    {
        this.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
