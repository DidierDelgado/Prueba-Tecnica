using UnityEngine;

public class destruirEnemigos : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject); // Destruye al enemigo cuando toque el trigger
        }
    }
}

