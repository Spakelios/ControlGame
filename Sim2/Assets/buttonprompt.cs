using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonprompt : MonoBehaviour
{
    public GameObject pause;
    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pause.SetActive(true);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("start");
    }
}
