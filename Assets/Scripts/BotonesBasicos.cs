using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesBasicos : MonoBehaviour
{
    public GameObject ObjetoActivar;
    public GameObject ObjetoADesactivar;

    public void abrir()
    {
        ObjetoActivar.SetActive(true);
    }
    
    public void cerrar()
    {
        ObjetoADesactivar.SetActive(false);
    }

    public void salir()
    {
        Application.Quit();
    }

}
