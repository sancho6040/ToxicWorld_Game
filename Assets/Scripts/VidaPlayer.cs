using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public float conta = 0;
    public Canvas canva;
    public Image barraVida;
    public Image barraConta;
    public GameObject player;
    public GameObject camara;
    public GameObject volumen;
    public Volume volumeScene;
    public VolumeProfile profiles;
    private Vignette vignette;
    private ChromaticAberration chromatic;
    private FilmGrain grain;
    private DepthOfField depth;

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

        if (vida <= 70)
        {
            grain.active=true;
        }
        else
        {
            grain.active = false;
        }

        if (vida <= 50)
        {
            depth.active = true;
        }
        else
        {
            depth.active = false;
        }

        if (vida <= 35)
        {
            chromatic.active = true;
        }
        else
        {
            chromatic.active = false;
        }

        if (vida <= 25)
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
            SceneManager.LoadScene(0);
        }

        conta = Mathf.Clamp(conta, 0, 100);
        barraConta.fillAmount = conta / 100;

        if (conta >= 0)
        {

        }

        if (conta >= 20)
        {

        }

        if (conta >= 40)
        {

        }

        if (conta >= 60)
        {

        }

        if (conta >= 80)
        {

        }

        if (conta >= 100)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
        }

    }
}
