using UnityEngine;
using TMPro; // Para manejar textos con TextMeshPro
using UnityEngine.SceneManagement; // Para cambiar escenas

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI puntajeTexto;
    public GameObject gameOverPanel; // Referencia al panel de Game Over
    private int puntaje = 0;
    private int puntajeMaximo = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            CargarPuntajeMaximo();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntaje(int puntos)
    {
        puntaje += puntos;
        ActualizarTextoPuntaje();

        if (puntaje > puntajeMaximo)
        {
            puntajeMaximo = puntaje;
            GuardarPuntajeMaximo();
        }
    }

    void ActualizarTextoPuntaje()
    {
        if (puntajeTexto != null)
        {
            puntajeTexto.text = "Puntaje: " + puntaje;
        }
    }

    void GuardarPuntajeMaximo()
    {
        PlayerPrefs.SetInt("PuntajeMaximo", puntajeMaximo);
        PlayerPrefs.Save();
    }

    void CargarPuntajeMaximo()
    {
        if (PlayerPrefs.HasKey("PuntajeMaximo"))
        {
            puntajeMaximo = PlayerPrefs.GetInt("PuntajeMaximo");
        }
    }

    public void ActivarGameOver()
    {
        gameOverPanel.SetActive(true); // Mostrar la pantalla gris con los botones
        Time.timeScale = 0f; // Pausar el juego
    }

    public void Reintentar()
    {
        
        Time.timeScale = 1f; // Restaurar el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recargar la escena

        
    }

    public void IrAlMenu()
    {
        Time.timeScale = 1f; // Restaurar el tiempo
        SceneManager.LoadScene("Menu Principal"); // Cambiar a la escena del menu
    }

    public void Jugar()
    {
        SceneManager.LoadScene ("Nivel 1");
    }
}