using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;

    public void PickupItem(int id)
    {
        bool result = inventoryManager.AddItem(itemsToPickup[id]);
        Debug.Log(result ? "item added" : "item not added");
    }

    public void GetSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedSlot(false);
        Debug.Log(receivedItem ? $"Item received: {receivedItem.name}" : "!!!NO item recived");
    }

    public void UseSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedSlot(true);
        Debug.Log(receivedItem ? $"Item used: {receivedItem.name}" : "!!!NO item used");
    }
}
