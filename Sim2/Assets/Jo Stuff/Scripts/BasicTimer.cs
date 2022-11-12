using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicTimer : MonoBehaviour
{
    private int time;
    public TextMeshProUGUI timer;
    public MinigameTestPlayer player;
    public GameObject winScreen;
    public GameObject loseScreen;
    private void Start()
    {
        time = 5;
        player = FindObjectOfType<MinigameTestPlayer>();
        StartCoroutine(Countdown());
    }
    private void Update()
    {
        timer.text = "Time remaining: " + time;
        
        
    }

    private IEnumerator Countdown()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;

            if (player.score < 3) continue;
            StopCoroutine(Countdown());
            Win();
        }
        
        Lose();


    }

    private void Win()
    {
        winScreen.SetActive(true);
    }

    private void Lose()
    {
        loseScreen.SetActive(true);
    }
}
