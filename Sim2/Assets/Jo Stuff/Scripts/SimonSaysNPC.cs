using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysNPC : MonoBehaviour
{
    public GameObject leftFlag;
    public GameObject rightFlag;
    public int flagNumber;
    public GameObject canvas;
    public int whichFlag;
    public List<int> flagOrder;
    
    private void OnEnable()
    {
       leftFlag.SetActive(false);
       rightFlag.SetActive(false);
       flagNumber = 0;
       canvas.SetActive(false);
       flagOrder = new List<int>();
       
       StartCoroutine(holdFlag());
    }

    private IEnumerator holdFlag()
    {
        while (flagNumber < 5)
        {
            flagNumber++;
            yield return new WaitForSeconds(1f);
            whichFlag = Random.Range(1, 4);

            switch (whichFlag)
            {
                case 1:
                    leftFlag.SetActive(true);
                    rightFlag.SetActive(false);
                    flagOrder.Add(whichFlag);
                    
                    yield return new WaitForSeconds(1f);
                    
                    leftFlag.SetActive(false);
                    rightFlag.SetActive(false);
                    break;
                case 2:
                    leftFlag.SetActive(false);
                    rightFlag.SetActive(true);
                    flagOrder.Add(whichFlag);
                    
                    yield return new WaitForSeconds(1f);
                    
                    leftFlag.SetActive(false);
                    rightFlag.SetActive(false);
                    break;
                case 3:
                    leftFlag.SetActive(true);
                    rightFlag.SetActive(true);
                    flagOrder.Add(whichFlag);
                    
                    yield return new WaitForSeconds(1f);
                    
                    leftFlag.SetActive(false);
                    rightFlag.SetActive(false);
                    break;
            }
        }
        
        canvas.SetActive(true);
    }
    
    
}
