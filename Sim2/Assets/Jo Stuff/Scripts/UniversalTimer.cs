using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UniversalTimer : MonoBehaviour
{
    public int time;
    public GameObject loseScreen;
    public TextMeshProUGUI timer;

    private void OnEnable()
    {
        time = 5;
        loseScreen.SetActive(false);
        StartCoroutine(Countdown());
    }

    private void OnDisable()
    {
        StopCoroutine(Countdown());
    }

    // Update is called once per frame
    private void Update()
    {
        timer.text = "Time remaining: " + time;
    }

    private IEnumerator Countdown()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1.5f);
            time--;
        }

        Lose();
    }

    private void Lose()
    {
        loseScreen.SetActive(true);
    }
}
