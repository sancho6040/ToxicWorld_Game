using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public Item itemSO;
    public Disolve disolve;

    private void Awake()
    {
        disolve = GetComponent<Disolve>();
    }

    public void PickupItem()
    {
        bool result = InventoryManager.Instance.AddItem(itemSO);
        Debug.Log(result ? "item added" : "item not added");
        //----------- lo de camilo xd -------
        if(result)
        {
            disolve.bDis = true;
        }

        //Destroy(gameObject);
    }
}
