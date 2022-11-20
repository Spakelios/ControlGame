using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Sprite heart;

    public void Update()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    IEnumerator spawn()
    {
        Instantiate(heart);

        yield return new WaitForSeconds(2);
       gameObject.SetActive(false);
    }
}
