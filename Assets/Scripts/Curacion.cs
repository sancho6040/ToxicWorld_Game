using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    VidaPlayer playerVida;
    public float cantidadVida;
    public float cantidadConta;
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerVida.vida += cantidadVida;
            playerVida.conta += cantidadConta;
            //Destroy(gameObject);
        }
    }
}
