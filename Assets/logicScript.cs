using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;



public class logicScript : MonoBehaviour
{
    private Random rnd = new Random();
    public int Snow;
    public int Icicle;
    public int SnowGem;
    public Text IcicleCounter;
    public Text SnowGemCounter;
    public Text SnowCounter;
    public GameObject Inventory;
    public GameObject Crafting;
    private bool InventoryOpen = false;
    private bool CraftingOpen = false;
   




    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd, string Tag)
    {
        if (Tag == "Snow")
        {
            
            int snows = rnd.Next(1, 5);
            Snow += snows;
            SnowCounter.text = Snow.ToString();
        }
        else if (Tag == "Icicle")
        {
            Icicle += scoreToAdd;
            IcicleCounter.text = Icicle.ToString();
        }
        else if (Tag == "IceGem")
        {
            SnowGem += scoreToAdd;
            SnowGemCounter.text = SnowGem.ToString();
        }


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

