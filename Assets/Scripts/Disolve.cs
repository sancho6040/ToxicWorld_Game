using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Disolve : MonoBehaviour
{
   // Renderer Rend;
    public Material m_Material;
    float StartValue = 0.0f;
    float EndValue = 1.0f;
    float ValueToLerp;
    float timeElapsed;
    [SerializeField] private float lerpDuration = 1.0f;
    public bool bDis=false;

    private void Start()
    {
        m_Material= GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }
    void Update()
    {

        if (bDis) 
        {
            ValueToLerp = Mathf.Lerp(StartValue, EndValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            m_Material.SetFloat("_DessolveAmount", ValueToLerp);
        }
        /* if (Input.GetKeyDown(KeyCode.A))
        {
            //Output the amount of materials before GameObject is destroyed
            print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
            //Destroy GameObject
            Destroy(gameObject);
        }*/
    }

    void OnDestroy()
    {
        //Destroy the instance
        Destroy(m_Material);
        //Output the amount of materials to show if the instance was deleted
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);

    }
}

