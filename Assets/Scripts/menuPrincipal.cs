using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene ("Nivel 1");
    }
}
