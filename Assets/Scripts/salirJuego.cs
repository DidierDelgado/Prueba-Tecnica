using UnityEngine;
using UnityEngine.UI;


public class salirJuego : MonoBehaviour
{
    public void ExitGameFunction() 
    {
        #if UNITY_EDITOR
            // Si estás en el Editor de Unity, solo detén la reproducción
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Si no estás en el Editor (en una compilación del juego), cerramos la aplicación
            Application.Quit();
        #endif

    }        

}

  

