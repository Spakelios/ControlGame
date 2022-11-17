using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    IEnumerator die()
    {
        yield return new WaitForSeconds(10);
        
        gameObject.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(die());
    }
}
