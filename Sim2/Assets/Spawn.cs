using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject heart;
    public GameObject spawner;

    public void Update()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    IEnumerator spawn()
    {
        Instantiate(heart, transform.position, heart.transform.rotation);

        yield return new WaitForSeconds(5);
        
        spawner.SetActive(false);
    }
}
