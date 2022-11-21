using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DrumTest : MonoBehaviour
{
    public TaikoDrumTest taikoDrum;
    public Image leftFace;
    public Image rightFace;
    public Image leftRim;
    public Image rightRim;

    private void OnEnable()
    {
        taikoDrum = new TaikoDrumTest();
        taikoDrum.Drum.Enable();
        leftFace = GameObject.Find("left face").GetComponent<Image>();
        rightFace = GameObject.Find("right face").GetComponent<Image>();;
        leftRim = GameObject.Find("left rim").GetComponent<Image>();;
        rightRim = GameObject.Find("right rim").GetComponent<Image>();
    }

    private void OnDisable()
    {
        leftFace.color = Color.white;
        rightFace.color = Color.white;
        leftRim.color = Color.gray;
        rightRim.color = Color.gray;
    }

    private void Update()
    {
        DrumCheck();
    }

    private void DrumCheck()
    {
        if (taikoDrum.Drum.LeftFace.triggered)
        {
            leftFace.color = Color.red;
            rightFace.color = Color.white;
            leftRim.color = Color.gray;
            rightRim.color = Color.gray;
        }
        
        else if (taikoDrum.Drum.RightFace.triggered)
        {
            rightFace.color = Color.red;
            leftFace.color = Color.white;
            leftRim.color = Color.gray;
            rightRim.color = Color.gray;
        }
        
        else if (taikoDrum.Drum.LeftRim.triggered)
        {
            leftRim.color = Color.blue;
            leftFace.color = Color.white;
            rightFace.color = Color.white;
            rightRim.color = Color.gray;
        }
        
        else if (taikoDrum.Drum.RightRim.triggered)
        {
            rightRim.color = Color.blue;
            leftFace.color = Color.white;
            rightFace.color = Color.white;
            leftRim.color = Color.gray;
        }

        /*
        else
        {
            leftFace.color = Color.white;
            rightFace.color = Color.white;
            leftRim.color = Color.gray;
            rightRim.color = Color.gray;
        }
        */
    }
}
