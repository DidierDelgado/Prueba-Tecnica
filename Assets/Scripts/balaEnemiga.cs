using UnityEngine;

public class balaEnemiga : MonoBehaviour
{
    public float Velocidad = 5f; // Velocidad de la bala

    void Update()
    {
        // Mueve la bala hacia abajo
        transform.Translate(Vector2.down * Velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Si la bala choca con el jugador, la destruimos
        if (collision.CompareTag("Jugador"))
        {
            Destroy(collision.gameObject); // Destruye al jugador 
            Destroy(gameObject); // Destruye la bala
        }

        // Si la bala sale de la pantalla, la destruimos
        if (collision.CompareTag("Fuera de pantalla"))
        {
            Destroy(gameObject);
        }
    }
}

