using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playDono : MonoBehaviour
{
 public GameObject Dono1;
 
 IEnumerator play()
 {
  yield return new WaitForSeconds(10);
  
  Dono1.SetActive(true);
  
  yield break;
 }
 

 public void Update()
 {
  StartCoroutine(play());
 }
}
