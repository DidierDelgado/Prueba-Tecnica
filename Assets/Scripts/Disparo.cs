using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefabDisparo;
    public float velocidadBala = 10f;

    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instanciar la bala
            GameObject bala = Instantiate(prefabDisparo, transform.position + Vector3.up, Quaternion.identity);

            // Agregar velocidad a la bala
            Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.up * velocidadBala;
            }
        }
    }
}

