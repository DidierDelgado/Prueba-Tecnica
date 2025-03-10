using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class salirJuego : MonoBehaviour
{
    public void ExitGameFunction() 
    {
        #if UNITY_EDITOR
            // Si estas en el Editor de Unity, solo deten la reproduccion
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Si no estas en el Editor (en una compilacion del juego), cerramos la aplicacion
            Application.Quit();
        #endif

    }        

}

  

