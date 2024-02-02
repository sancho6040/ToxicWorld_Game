using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prop : MonoBehaviour
{
              
    public Item itemSO;
    public Disolve disolve;
   
    public bool bIsBone = false;

    private void Awake()
    {
        if (bIsBone)
        {
            disolve = GetComponent<Disolve>();
        }
        
        
    }

    public void PickupItem()
    {
        bool result = InventoryManager.Instance.AddItem(itemSO);
        Debug.Log(result ? "item added" : "item not added");
        //----------- lo de camilo xd -------
        if (result)
        {
            if (bIsBone)
            {
                Debug.Log("Si se activo"); 
                disolve.bDis=true;
              

            }
            else
            {
                Debug.Log("destroy");
                Destroy(gameObject);
            }
           
           

        }

    }
}
