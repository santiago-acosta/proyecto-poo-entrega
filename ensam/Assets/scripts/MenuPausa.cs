using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuPausa : MonoBehaviour
{
    public bool Pausa;
    public bool Opciones;
    public GameObject MenuPausaCanvas;
    public GameObject OpcionesCanvas;
    public Dropdown resolucionDropdown;
    Resolution[] resolutions;
    void Start()
    {
        resolutions = Screen.resolutions;
        resolucionDropdown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucion = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string opcion = resolutions[i].width + " x " + resolutions[i].height;
            opciones.Add(opcion);
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                resolucion = i;
            }
        }
        resolucionDropdown.AddOptions(opciones);
        resolucionDropdown.value = resolucion;
        resolucionDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Pausa)
        {
            MenuPausaCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            MenuPausaCanvas.SetActive(false);
            Time.timeScale = 1;
        }
        if (Opciones)
        {
            OpcionesCanvas.SetActive(true);
        }
        else
        {
            OpcionesCanvas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausa = !Pausa;
            Opciones = false;

        }
    }
    public void reiniciar(){
        SceneManager.LoadScene("nivel_1");
    }
    public void Continuar()
    {
        Pausa = false;
    }   
    public void SalirMenuPrincipal(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
    public void Atras()
    {
        Opciones = false;
    }
    public void Opcionesbuttom()
    {
        Opciones = true;
    }
    public void CambiarVolumen(float Volumen)
    {
        Debug.Log(Volumen);
    }
    public void Cambiarcalidad(int Calidad)
    {
        QualitySettings.SetQualityLevel(Calidad);
    }
    public void PantallaCompleta(bool Pantalla)
    {
        Screen.fullScreen = Pantalla;
    }
    public void CambiarResolucion(int Resolucion)
    {
        Resolution resolution = resolutions[Resolucion];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
