using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    [SerializeField]
    private string itemName;
    [SerializeField]
    private Sprite sprite;

    public InventoryManager inventoryManager;
    private bool mouseOver = false;

    void Start()
    {
        inventoryManager = GameObject.Find("Canvas").GetComponent<InventoryManager>();
    }

    void Update()
    {
        if (mouseOver && Input.GetMouseButtonDown(0))
        {
            inventoryManager.AddItem(itemName, sprite);
            Destroy(gameObject);
        }
    }

    void OnMouseEnter()
    {
        mouseOver = true;
    }

    void OnMouseExit()
    {
        mouseOver = false;
    }
}
