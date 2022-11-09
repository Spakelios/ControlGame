using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DrumTest : MonoBehaviour
{
    public TaikoDrumTest taikoDrum;
    public SpriteRenderer leftFace;
    public SpriteRenderer rightFace;
    public SpriteRenderer leftRim;
    public SpriteRenderer rightRim;

    private void Start()
    {
        taikoDrum = new TaikoDrumTest();
        taikoDrum.Drum.Enable();
        leftFace = GameObject.Find("left face").GetComponent<SpriteRenderer>();
        rightFace = GameObject.Find("right face").GetComponent<SpriteRenderer>();
        leftRim = GameObject.Find("left rim").GetComponent<SpriteRenderer>();
        rightRim = GameObject.Find("right rim").GetComponent<SpriteRenderer>();
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
