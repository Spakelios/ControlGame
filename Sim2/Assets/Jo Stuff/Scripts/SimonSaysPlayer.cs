using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysPlayer : MonoBehaviour
{
    public GameObject leftFlag;
    public GameObject rightFlag;
    private TaikoDrumTest taikoDrum;
    private UniversalTimer timer;
    public GameObject winScreen;
    public GameObject loseScreen;
    public List<int> playerFlag;
    private SimonSaysNPC npc;
    
    private void Start()
    {
        taikoDrum = new TaikoDrumTest();
        npc = FindObjectOfType<SimonSaysNPC>();
        timer = FindObjectOfType<UniversalTimer>();
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        playerFlag = new List<int>();
        taikoDrum.Drum.Enable();
        leftFlag.SetActive(false);
        rightFlag.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerFlag.Count < 5)
        {
            if (taikoDrum.Drum.LeftRim.triggered)
            {
                leftFlag.SetActive(true);
                rightFlag.SetActive(false);
                playerFlag.Add(1);
                StartCoroutine(PutDownFlag());
            }
        
            else if (taikoDrum.Drum.RightRim.triggered)
            {
                leftFlag.SetActive(false);
                rightFlag.SetActive(true);
                playerFlag.Add(2);
                StartCoroutine(PutDownFlag());
            }
        
            else if (taikoDrum.Drum.LeftFace.triggered || taikoDrum.Drum.RightFace.triggered)
            {
                leftFlag.SetActive(true);
                rightFlag.SetActive(true);
                playerFlag.Add(3);
                StartCoroutine(PutDownFlag());
            }
        }

        else
        {
            CompareLists();
        }
    }

    private IEnumerator PutDownFlag()
    {
        while (leftFlag.activeInHierarchy || rightFlag.activeInHierarchy)
        {
            yield return new WaitForSeconds(0.5f);
            leftFlag.SetActive(false);
            rightFlag.SetActive(false);
        }
        
        StopCoroutine(PutDownFlag());
    }

    private void CompareLists()
    {
        for (int i = 0; i < playerFlag.Count; i++)
        {
            if (npc.flagOrder[i] != playerFlag[i])
            {
                //Debug.Log(false);
                timer.StopAllCoroutines();
                loseScreen.SetActive(true);
            }

            else if (npc.flagOrder[i] == playerFlag[i])
            {
                //Debug.Log(true);
                timer.StopAllCoroutines();
                winScreen.SetActive(true);
            }
        }
    }
}
