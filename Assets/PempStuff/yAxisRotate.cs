﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class yAxisRotate : MonoBehaviour, IInputClickHandler {

    bool selected = false;
    private Shader x;
    private Shader defaultShader;


    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (!selected)
        {
            this.GetComponent<Renderer>().material.shader = x;
            selected = true;
        }
        else
        {
            this.GetComponent<Renderer>().material.shader = defaultShader;
            selected = false;
        }
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start()
    {

        defaultShader = this.GetComponent<Renderer>().material.shader;
        x = Shader.Find("Legacy Shaders/Bumped Diffuse");

    }

    // Update is called once per frame
    void Update()
    {


    }
}