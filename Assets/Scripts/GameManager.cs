using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    public Text scoreText;
    public PlayerMovement playerMovement;
    public GameObject endCanvas; // Canvas final
    public Text endScoreText;    // Texto del Canvas final

    private void Awake()
    {
        inst = this;
    }

    // Incrementa el puntaje y actualiza el texto en pantalla
    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;

        // Aumenta la velocidad del jugador
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    // Llama este m�todo cuando el juego termina
    public void EndGame()
    {
        playerMovement.enabled = false; // Det�n el movimiento del jugador
        endCanvas.SetActive(true);      // Activa el Canvas final
        endScoreText.text = "Monedas recogidas: " + score; // Muestra el puntaje final
    }

    void Start()
    {
        endCanvas.SetActive(false); // Aseg�rate de que el Canvas final est� desactivado al inicio
    }
}
