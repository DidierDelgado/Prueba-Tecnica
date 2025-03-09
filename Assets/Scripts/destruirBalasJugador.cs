using UnityEngine;

public class DestroyerBalas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BalasJugador")) // Verifica si el objeto es una bala del jugador
        {
            Destroy(other.gameObject); // Destruye la bala
        }
    }
}
