using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject basketball;
    public GameObject striker;
    public GameObject simon;
    private GameObject currentGame;
    public List<int> gameOrder;
    public int gameID;
    
    private void Start()
    {
        
        basketball.SetActive(false);
        striker.SetActive(false);
        simon.SetActive(false);
        
    }

    public void GameTime()
    {
        while (gameOrder.Count < 3)
        {
            gameID = Random.Range(1, 4);

            if (!gameOrder.Contains(gameID))
            {
                gameOrder.Add(gameID);
            }
        }

        GameOne();
    }



    private void GameOne()
    {
        switch (gameOrder[0])
        {
            case 1:
                currentGame = basketball;
                currentGame.SetActive(true);
                break;
            case 2:
                currentGame = striker;
                currentGame.SetActive(true);
                break;
            case 3:
                currentGame = simon;
                currentGame.SetActive(true);
                break;
        }
    }

    private void GameTwo()
    {
        currentGame.SetActive(false);
        currentGame = null;
        
        switch (gameOrder[1])
        {
            case 1:
                currentGame = basketball;
                currentGame.SetActive(true);
                break;
            case 2:
                currentGame = striker;
                currentGame.SetActive(true);
                break;
            case 3:
                currentGame = simon;
                currentGame.SetActive(true);
                break;
        }
    }

    private void GameThree()
    {
        currentGame.SetActive(false);
        currentGame = null;
        
        switch (gameOrder[2])
        {
            case 1:
                currentGame = basketball;
                currentGame.SetActive(true);
                break;
            case 2:
                currentGame = striker;
                currentGame.SetActive(true);
                break;
            case 3:
                currentGame = simon;
                currentGame.SetActive(true);
                break;
        }
    }

    public void RestartGame()
    {
        gameOrder.Clear();
        currentGame = null;
        basketball.SetActive(false);
        striker.SetActive(false);
        simon.SetActive(false);
    }
}
