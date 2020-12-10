using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public Dropdown resolucionDropdown;
    public GameObject OpcionesCanvas;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        OpcionesCanvas.SetActive(false);
        resolutions = Screen.resolutions;
        resolucionDropdown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucion = 0;
        for(int i = 0;i < resolutions.Length; i++)
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
        

    }
    public void CambiarEscenas(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
    public void Atras()
    {
        OpcionesCanvas.SetActive(false);
    }
    public void Opcionesbuttom()
    {
        OpcionesCanvas.SetActive(true);
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
