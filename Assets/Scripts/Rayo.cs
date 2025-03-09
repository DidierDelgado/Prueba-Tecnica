using UnityEngine;

public class Rayo : MonoBehaviour
{
    private int puntosPorEnemigo = 0; // Puntos que suma al destruir un enemigo

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo")) 
        {
            Enemigo enemigo = other.GetComponent<Enemigo>();
            if (enemigo != null)
            {
                enemigo.Morir(); // Destruir al enemigo primero

                // Sumar puntos al GameManager solo si el enemigo fue destruido
                if (GameManager.Instance != null)
                {
                    GameManager.Instance.SumarPuntaje(puntosPorEnemigo);
                }
            }

            // Destruir la bala al impactar
            Destroy(gameObject);
        }
    }
}

