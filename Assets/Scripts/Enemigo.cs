using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int puntaje = 100; // Puntaje que este enemigo otorga al morir

    public void Morir()
    {
        // Llamar a la función para sumar el puntaje
        GameManager.Instance.SumarPuntaje(puntaje);

        // Destruir el enemigo
        Destroy(gameObject);
    }
}

