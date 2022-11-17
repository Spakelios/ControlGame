using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class playDono : MonoBehaviour
{
 public GameObject Dono1;
 public GameObject Dono2;



 IEnumerator play()
 {
  yield return new WaitForSeconds(10);

  Dono1.SetActive(true);

  yield break;
 }

 IEnumerator play2()
 {
  yield return new WaitForSeconds(10);

  Dono2.SetActive(true);
 }

 public int digit;

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.Backspace))
  {
   digit = Random.Range(0, 10);
   if (digit <= 5)
   {
    StartCoroutine(play());
   }

   if (digit >= 5)
   {
    StartCoroutine(play2());
   }
  }
 }
}



