using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballPlayer : MonoBehaviour
{
    public TaikoDrumTest taikoDrum;
    
    public GameObject player;
    
    public GameObject pointLeft;
    public GameObject pointMiddle;
    public GameObject pointRight;

    public GameObject leftBall;
    public GameObject middleBall;
    public GameObject rightBall;

    public Transform leftBallStart;
    public Transform middleBallStart;
    public Transform rightBallStart;

    public GameObject leftHoop;
    public GameObject middleHoop;
    public GameObject rightHoop;

    public GameObject hand;
    
    private bool atLeft;
    private bool atMiddle;
    private bool atRight;

    private bool holdingBall;

    public int score;

    public UniversalTimer timer;
    public GameObject winScreen;

    private void OnEnable()
    {
        taikoDrum = new TaikoDrumTest();
        taikoDrum.Drum.Enable();
        leftBall.transform.position = leftBallStart.position;
        middleBall.transform.position = middleBallStart.position;
        rightBall.transform.position = rightBallStart.transform.position;
        player = gameObject;
        player.transform.position = pointMiddle.transform.position;
        atLeft = false;
        atMiddle = true;
        atRight = false;
        holdingBall = false;
        score = 0;
    }

    private void Update()
    {
        Move();

        if (score >= 3)
        {
            timer.StopAllCoroutines();
            winScreen.SetActive(true);
            
        }
    }

        private void Move()
    {
        if (!holdingBall)
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

        else
        {
            ThrowBall();
        }
    }

    private void Ball()
    {
        if (atMiddle)
        {
            middleBall.transform.position = hand.transform.position;
            holdingBall = true;
        }
        
        else if (atLeft)
        {
            leftBall.transform.position = hand.transform.position;
            holdingBall = true;
        }

        else
        {
            rightBall.transform.position = hand.transform.position;
            holdingBall = true;
        }
    }

    private void ThrowBall()
    {
        if (!taikoDrum.Drum.LeftRim.triggered && !taikoDrum.Drum.RightRim.triggered) return;
        if (atMiddle)
        {
            middleBall.transform.position = middleHoop.transform.position;
            holdingBall = false;
            score++;
        }
            
        else if (atLeft)
        {
            leftBall.transform.position = leftHoop.transform.position;
            holdingBall = false;
            score++;
        }

        else
        {
            rightBall.transform.position = rightHoop.transform.position;
            holdingBall = false;
            score++;
        }
    }
}
