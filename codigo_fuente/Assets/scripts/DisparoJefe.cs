using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisparoJefe : MonoBehaviour
{
    public float Velocidad_Bala;
    public float  Cadencia;
    public float  CadenciaMax;
    public float reduccionCadencia;
    public GameObject arma;
    public GameObject bala;
    public Transform Pos_jugador;
    public Image Salud;
    
    private float Tiempo;
    private float cadenciaAux;
    private GameObject BalaClon;
    private bool MayorCad=false;
    void Start(){
        cadenciaAux=Cadencia;
    }

    // Update is called once per frame
    void Update()
    {   Tiempo += Time.deltaTime;
        if(Salud.fillAmount<0.4 && MayorCad==false){
            MayorCad=true;
            CadenciaMax-=0.3f;
            Velocidad_Bala *=1.5f ;
        }
            
        if(Tiempo>=Cadencia){
            BalaClon = Instantiate(bala, transform.position, transform.rotation);
            BalaClon.tag="Bala_Clon";        
            Tiempo=0;
            if (Cadencia>=CadenciaMax)
                Cadencia-=reduccionCadencia;
            else
            {
                Cadencia = cadenciaAux;
            }
        }
    }
    
}