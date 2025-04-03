using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    //==ITEM DATA==//
    public string itemName;
    public Sprite itemSprite;
    public bool isFull;

    [SerializeField] private Image itemImage;

    private void Start()
    {
        // Initialize with transparent image if not full
        UpdateSlotVisibility();
    }

    public void AddItem(string itemName, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.itemSprite = itemSprite;
        isFull = true;
        itemImage.sprite = itemSprite;
        UpdateSlotVisibility();
    }

    public void ClearSlot()
    {
        itemName = "";
        itemSprite = null;
        isFull = false;
        itemImage.sprite = null;
        UpdateSlotVisibility();
    }

    private void UpdateSlotVisibility()
    {
        Color imageColor = itemImage.color;
        imageColor.a = isFull ? 1f : 0f; // 1 = fully visible, 0 = fully transparent
        itemImage.color = imageColor;
    }
}