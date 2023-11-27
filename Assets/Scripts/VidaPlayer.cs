using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Canvas canva;
    public Image barraVida;
    public GameObject player;
    public GameObject camara;
    public GameObject volumen;
    public Volume volumeScene;
    public VolumeProfile profiles;
    public Vignette vignette;
    public ChromaticAberration chromatic;
    public FilmGrain grain;
    public DepthOfField depth;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //camara = player.transform.Find("MainCamera").gameObject;
        camara = GameObject.FindWithTag("MainCamera");

        profiles.TryGet(out vignette);
        profiles.TryGet(out chromatic);
        profiles.TryGet(out grain);
        profiles.TryGet(out depth);

    }

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraVida.fillAmount = vida / 100;

        if (vida <= 50)
        {
            grain.active=true;
        }
        else
        {
            grain.active = false;
        }

        if (vida <= 30)
        {
            depth.active = true;
        }
        else
        {
            depth.active = false;
        }

        if (vida <= 20)
        {
            chromatic.active = true;
        }
        else
        {
            chromatic.active = false;
        }

        if (vida <= 10)
        {
            vignette.active = true;
        }
        else
        {
            vignette.active = false;
        }

        if (vida <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(6);
        }
    }
}
