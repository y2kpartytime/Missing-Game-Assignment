using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    private bool inventoryOpen = false;
    public GameObject InventoryMenu;
    public Button InventoryButton;
    public ItemSlot[] itemSlot;

    // Start is called before the first frame update
    void Start()
    {
        InventoryMenu.SetActive(false);
        InventoryButton.onClick.AddListener(ShowInventory);
    }

    public void ShowInventory()
    {
        inventoryOpen = !inventoryOpen;
        InventoryMenu.SetActive(inventoryOpen);
    }

    public void AddItem(string itemName, Sprite itemSprite)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].isFull == false)
            {
                itemSlot[i].AddItem(itemName, itemSprite);
                return;
            }
        }
    }
}
