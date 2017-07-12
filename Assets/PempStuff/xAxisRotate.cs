﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class xAxisRotate : MonoBehaviour,IInputClickHandler {

    bool selected = false;
    private Shader x;
    private Shader defaultShader;


    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Click function");
        if (!selected)
        {
            this.GetComponent<Renderer>().material.shader = x;
            Debug.Log("X is deselected");
            selected = true;
        }
        else
        {
            this.GetComponent<Renderer>().material.shader = defaultShader;
            selected = false;
            Debug.Log("X is deselected");
        }
        //throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {

        defaultShader = this.GetComponent<Renderer>().material.shader;
        x = Shader.Find("Legacy Shaders/Bumped Diffuse");

	}
	
	// Update is called once per frame
	void Update () {


    }
}
