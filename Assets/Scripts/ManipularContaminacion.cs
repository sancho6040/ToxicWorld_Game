using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularContaminacion : MonoBehaviour
{
    VidaPlayer playerVida;
    public int cantidad;
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerVida.conta += cantidad;
            //Destroy(gameObject);
        }
    }
}
