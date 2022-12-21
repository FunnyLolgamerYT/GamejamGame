using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject Inventory;
    private bool InventoryOpen = false;
   




    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (InventoryOpen)
            {
                Inventory.SetActive(false);
                InventoryOpen = false;
            }
            else
            {
                Inventory.SetActive(true);
                InventoryOpen = true;
            }
        }
    }
}

