using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStuff : MonoBehaviour
{
    public TextMeshProUGUI name;

    private void Start()

    {
        name.text = InputEntry.playerName.ToString();
    }
}