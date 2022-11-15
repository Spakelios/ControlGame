using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStuff : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI name2;

    private void Start()

    {
        name.text = InputEntry.playerName.ToString();
        name2.text = InputEntry.playerName.ToString();
    
    }
}