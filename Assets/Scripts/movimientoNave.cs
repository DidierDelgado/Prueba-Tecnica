using UnityEngine;

public class movimientoNave : MonoBehaviour
{
    public float velocidad = 0.5f;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.up * Time.deltaTime * velocidad * Input.GetAxis("Vertical"));
    }

    // Detectar colisión con los disparos enemigos
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DisparoEnemigo")) // Si el jugador es golpeado
        {
            GameManager.Instance.ActivarGameOver(); // Llamar al Game Over
            Destroy(gameObject); // Destruir al jugador
        }
    }
}
