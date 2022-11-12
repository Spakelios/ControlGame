using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class MinigameTestPlayer : MonoBehaviour
{
    public TaikoDrumTest taikoDrum;
    
    public GameObject player;
    
    public GameObject pointLeft;
    public GameObject pointMiddle;
    public GameObject pointRight;

    public GameObject leftBall;
    public GameObject middleBall;
    public GameObject rightBall;
    
    private bool atLeft;
    private bool atMiddle;
    private bool atRight;
    
    private void Start()
    {
        taikoDrum = new TaikoDrumTest();
        taikoDrum.Drum.Enable();
        player = gameObject;
        player.transform.position = pointMiddle.transform.position;
        atLeft = false;
        atMiddle = true;
        atRight = false;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (taikoDrum.Drum.LeftFace.triggered)
        {
            if (atMiddle)
            {
                player.transform.position = pointLeft.transform.position;
                atLeft = true;
                atMiddle = false;
                atRight = false;
            }
            
            else if (atRight)
            {
                player.transform.position = pointMiddle.transform.position;
                atLeft = false;
                atMiddle = true;
                atRight = false;
            }

            else
            {
                Debug.Log("Can't move out of bounds!");
            }
        }
        
        else if (taikoDrum.Drum.RightFace.triggered)
        {
            if (atMiddle)
            {
                player.transform.position = pointRight.transform.position;
                atLeft = false;
                atMiddle = false;
                atRight = true;
            }
            
            else if (atLeft)
            {
                player.transform.position = pointMiddle.transform.position;
                atLeft = false;
                atMiddle = true;
                atRight = false;
            }
            
            else
            {
                Debug.Log("Can't move out of bounds!");
            }
        }
        
        else if (taikoDrum.Drum.LeftRim.triggered || taikoDrum.Drum.RightRim.triggered)
        {
            Ball();
        }
    }

    private void Ball()
    {
        
    }
}
