using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UniversalTimer : MonoBehaviour
{
    public int time;
    public TextMeshProUGUI timer;

    private void Start()
    {
        time = 5;
        StartCoroutine(Countdown());
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
    }
}
