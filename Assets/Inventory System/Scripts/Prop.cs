using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public Item itemSO;

    public void PickupItem()
    {
        bool result = InventoryManager.Instance.AddItem(itemSO);
        Debug.Log(result ? "item added" : "item not added");
        //----------- lo de camilo xd -------

        Destroy(gameObject);
    }
}
