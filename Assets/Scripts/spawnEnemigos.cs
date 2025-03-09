using UnityEngine;
using System.Collections;

public class spawnEnemigos : MonoBehaviour
{
    public GameObject enemigoPrefabG; // Prefab del enemigo
    public GameObject enemigoPrefabM; // Prefab del enemigo
    public GameObject enemigoPrefabP; // Prefab del enemigo

    public float spawnRateMin = 1f;  // Tiempo mínimo entre spawns
    public float spawnRateMax = 6f;  // Tiempo máximo entre spawns
    public float minX = -2.5f, maxX = 2.5f; // Rango de aparición en X

    void Start()
    {
        StartCoroutine(SpawnEnemies()); // Inicia la corrutina para generar enemigos
    }

    IEnumerator SpawnEnemies()
    {
        while (true) // Loop infinito para spawnear enemigos continuamente
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
            Instantiate(enemigoPrefabG, spawnPosition, Quaternion.identity); // Instancia enemigo sin inclinación
            Instantiate(enemigoPrefabM, spawnPosition, Quaternion.identity); // Instancia enemigo sin inclinación
            Instantiate(enemigoPrefabP, spawnPosition, Quaternion.identity); // Instancia enemigo sin inclinación

            float waitTime = Random.Range(spawnRateMin, spawnRateMax); // Tiempo aleatorio entre spawns
            yield return new WaitForSeconds(waitTime); // Espera antes de spawnear otro enemigo
        }
    }
}

