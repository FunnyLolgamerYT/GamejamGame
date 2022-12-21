using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;



public class logicScript : MonoBehaviour
{
    private Random rnd = new Random();
    public bool SnowDagger = false;
    public int Snow;
    public int Icicle;
    public int SnowGem;
    public Text IcicleCounter;
    public Text SnowGemCounter;
    public Text SnowCounter;
    public GameObject Inventory;
    public GameObject Crafting;
    public GameObject DaggerCheck;
    public GameObject DaggerCross;
    private bool InventoryOpen = false;
    private bool CraftingOpen = false;


    

    [ContextMenu("Increase Score")]
    public void CraftDagger()
    {
        
        if (Snow >= 1 && Icicle >= 2 )
        {
            Debug.Log("You crafted a Dagger");
            SnowDagger = true;
            Snow -= 1;
            Icicle -= 2;
        }
    }

    public void addScore(int scoreToAdd, string Tag)
    {
        if (Tag == "Snow")
        {
            
            int snows = rnd.Next(1, 5);
            Snow += snows;
            
        }
        else if (Tag == "Icicle")
        {
            Icicle += scoreToAdd;
            
        }
        else if (Tag == "IceGem")
        {
            SnowGem += scoreToAdd;
            
        }


    }

    void Update()
    {
        SnowCounter.text = Snow.ToString();
        IcicleCounter.text = Icicle.ToString();
        SnowGemCounter.text = SnowGem.ToString();

        if (SnowDagger)
        {
            DaggerCheck.SetActive(true);
            DaggerCross.SetActive(false);
            
        }
        else if (!SnowDagger)
        {
            DaggerCheck.SetActive(false);
            DaggerCross.SetActive(true);
        }
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

