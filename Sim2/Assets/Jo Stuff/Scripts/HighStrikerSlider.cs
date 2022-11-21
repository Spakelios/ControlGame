using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighStrikerSlider : MonoBehaviour
{
    public int progress;
    public Slider slider;
    public GameObject sssslider;

    public bool goUp;
    public bool goDown;

    private TaikoDrumTest taikoDrum;
    public GameObject winScreen;
    public GameObject loseScreen;

    public UniversalTimer timer;
    // Start is called before the first frame update
    private void OnEnable()
    {
        progress = Mathf.Clamp(progress, 0, 50);
        slider.value = progress;
        goUp = true;
        goDown = false;

        taikoDrum = new TaikoDrumTest();
        taikoDrum.Drum.Enable();
    }

    private void Update()
    {
        if (taikoDrum.Drum.LeftFace.triggered || taikoDrum.Drum.RightFace.triggered)
        {
            hitBell();
        }
        
        else if (timer.time == 0)
        {
            Lose();
        }
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (goUp)
        {
            BarUp();
        }
        
        else if (goDown)
        {
            BarDown();
        }
        
        slider.value = progress;
    }

    private void BarUp()
    {
        if (progress < 50)
        {
            goUp = true;
            goDown = false;
        }

        else
        {
            goUp = false;
            goDown = true;
        }
        
        progress++;
    }

    private void BarDown()
    {
        if (progress != 0)
        {
            goUp = false;
            goDown = true;
        }

        else
        {
            goUp = true;
            goDown = false;
        }
        
        progress--;
    }

    private void hitBell()
    {
        timer.StopAllCoroutines();;
        goUp = false;
        goDown = false;

        if (progress >= 45)
        {
            winScreen.SetActive(true);
            sssslider.SetActive(false);
        }

        else
        {
            loseScreen.SetActive(true);
            sssslider.SetActive(false);
        }
    }

    private void Lose()
    {
        goUp = false;
        goDown = false;
        sssslider.SetActive(false);
    }
}
