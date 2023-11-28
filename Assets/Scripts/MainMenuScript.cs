using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioClip[] backgroundMusicList; // Lista de clips de música, agrégales desde el Inspector
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
        // Reproducir música aleatoria en bucle
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false; // Desactivar el bucle para poder detectar cuando termina la canción
        audioSource.volume = 0.6f;
        ReproducirCancionAleatoria();
    }

    void Update()
    {
        // Cambiar a una nueva canción cuando la actual haya terminado
        if (!audioSource.isPlaying)
        {
            ReproducirCancionAleatoria();
        }

        // Puedes agregar aquí lógica adicional si es necesario
    }

    void ReproducirCancionAleatoria()
    {
        // Seleccionar una canción aleatoria
        int randomIndex = Random.Range(0, backgroundMusicList.Length);
        AudioClip randomClip = backgroundMusicList[randomIndex];

        // Reproducir la canción seleccionada
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
        // Cerrar la aplicación
        Application.Quit();
    }
}
