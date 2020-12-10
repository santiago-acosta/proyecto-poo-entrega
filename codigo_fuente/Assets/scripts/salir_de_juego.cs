using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class salir_de_juego : MonoBehaviour
{
    public void salir(){
        Application.Quit();
    }
    public void volverAMenuPrincipal(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }
    public void restart(){
        SceneManager.LoadScene("nivel_1");
    }
}
