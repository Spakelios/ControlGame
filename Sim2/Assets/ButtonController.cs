using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject spawner;

    
    public void woah()
    {
        if (name == "woah0")
        {
            InfoStorage.Kei++;
            spawner.SetActive(true);

        }

        if (name == "woah1")
        { 
           
        }
        
 
    }
}
