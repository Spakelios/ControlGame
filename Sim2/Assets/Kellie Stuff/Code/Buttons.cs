using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

 public GameObject cam1;
 public GameObject cam2;
 public GameObject cam3;
 public GameObject cam4;

 public void cameras()
 {
  cam1.SetActive(true);
  cam2.SetActive(false);
  cam3.SetActive(false);
  cam4.SetActive(false);
 }

 public void camera1()
 {
  cam1.SetActive(false);
  cam2.SetActive(true);
  cam3.SetActive(false);
  cam4.SetActive(false);
 }

 public void camera2()
 {
  cam1.SetActive(false);
  cam2.SetActive(false);
  cam3.SetActive(true);
  cam4.SetActive(false);
 }
 
 public void camera3()
 {
  cam1.SetActive(false);
  cam2.SetActive(false);
  cam3.SetActive(false);
  cam4.SetActive(true);
 }

 public void pop()
 {
  cam1.SetActive(false);
  cam2.SetActive(true);
 }
 
 public void newscene()
 {
  SceneManager.LoadScene("VN Kellie");
 }
}
