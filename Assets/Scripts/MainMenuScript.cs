using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioClip[] backgroundMusicList; // Lista de clips de m�sica, agr�gales desde el Inspector
    private AudioSource audioSource;

    public AudioSource buttonSound; // Asigna el AudioSource desde el Inspector

    public void MouseHover()
    {
        // Reproducir el sonido cuando el mouse entra
        if (buttonSound != null)
        {
            buttonSound.Play();
        }
    }

    void Start()
    {
        // Reproducir m�sica aleatoria en bucle
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false; // Desactivar el bucle para poder detectar cuando termina la canci�n
        audioSource.volume = 0.6f;
        ReproducirCancionAleatoria();
    }

    void Update()
    {
        // Cambiar a una nueva canci�n cuando la actual haya terminado
        if (!audioSource.isPlaying)
        {
            ReproducirCancionAleatoria();
        }

        // Puedes agregar aqu� l�gica adicional si es necesario
    }

    void ReproducirCancionAleatoria()
    {
        // Seleccionar una canci�n aleatoria
        int randomIndex = Random.Range(0, backgroundMusicList.Length);
        AudioClip randomClip = backgroundMusicList[randomIndex];

        // Reproducir la canci�n seleccionada
        audioSource.clip = randomClip;
        audioSource.Play();
    }

    public void CambiarEscena(string nombreEscena)
    {
        // Cambiar a la siguiente escena
        SceneManager.LoadScene(nombreEscena);
    }

    public void CerrarJuego()
    {
        // Cerrar la aplicaci�n
        Application.Quit();
    }
}
