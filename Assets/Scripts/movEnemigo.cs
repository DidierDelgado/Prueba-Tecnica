using UnityEngine;

public class movEnemigo : MonoBehaviour
{
    public float Velocidad = 2f; // Velocidad de la nave enemiga

    void Update()
    {
        // Mueve la nave hacia abajo
        transform.Translate(Vector2.down * Velocidad * Time.deltaTime);
    }
}

