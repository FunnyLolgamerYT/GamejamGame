using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject Inventory;
    public GameObject Crafting;
    private bool InventoryOpen = false;
    private bool CraftingOpen = false;
   




    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && !CraftingOpen )
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
        if (Input.GetKeyDown(KeyCode.E) && !InventoryOpen )
        {
            if (CraftingOpen)
            {
                Crafting.SetActive(false);
                CraftingOpen = false;
            }
            else
            {
                Crafting.SetActive(true);
                CraftingOpen = true;
            }
        }
    }
}

