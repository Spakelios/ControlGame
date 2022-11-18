using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class playDono : MonoBehaviour
{
 public GameObject Dono1;
 public GameObject Dono2; 
 public GameObject Dono3;
 public GameObject Dono4;



 IEnumerator play()
 {
  yield return new WaitForSeconds(5);

  Dono1.SetActive(true);

  yield break;
 }

 IEnumerator play2()
 {
  yield return new WaitForSeconds(5);

  Dono2.SetActive(true);
 }
 
 IEnumerator play3()
 {
  yield return new WaitForSeconds(5);

  Dono3.SetActive(true);
 }
 IEnumerator play4()
 {
  yield return new WaitForSeconds(5);

  Dono4.SetActive(true);
 }
 public int digit;

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.Backspace))
  {
   
   digit = Random.Range(1, 4);
   if (digit == 1)
   {
    StartCoroutine(play());
   }

   if (digit == 2)
   {
    StartCoroutine(play2());
   }
   if (digit == 3)
   {
    StartCoroutine(play3());
   }
   
   if (digit == 4)
   {
    StartCoroutine(play4());
   }
  }
 }
}



