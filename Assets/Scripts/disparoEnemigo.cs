using UnityEngine;
using System.Collections;

public class disparoEnemigo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float tiempoEntreDisparos = 2f;
    private bool puedeDisparar = false;

    public void ActivarDisparo()
    {
        if (!puedeDisparar)
        {
            puedeDisparar = true;
            StartCoroutine(Disparar());
        }
    }

    IEnumerator Disparar()
    {
        while (puedeDisparar)
        {
            Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
            yield return new WaitForSeconds(tiempoEntreDisparos);
        }
    }
}



