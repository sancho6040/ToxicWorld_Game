using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check_Progress : MonoBehaviour
{
    public GameObject[] BonesCount;
    // Start is called before the first frame update
    void Start()
    {
      
        BonesCount = GameObject.FindGameObjectsWithTag("Bones");
       
     
        
    }
    private void Update()
    {
        BonesCount = GameObject.FindGameObjectsWithTag("Bones");
        Debug.Log(BonesCount);

        // Check the game estate defining the win condition
        if (BonesCount.Length == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }
    }
    
    

    

}
