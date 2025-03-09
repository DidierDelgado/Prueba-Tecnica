using UnityEngine;

public class activarDisparoEnemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo")) // Verifica si el objeto es un enemigo
        {
            disparoEnemigo disparo = other.GetComponent<disparoEnemigo>();
            if (disparo != null)
            {
                disparo.ActivarDisparo();
            }
        }
    }
}
