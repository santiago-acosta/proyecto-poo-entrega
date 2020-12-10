using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_fondo : MonoBehaviour 
{
    [Range(-10f,10f)]
    public float vel_desplazamiento=0.5f;
    private float tasa_de_cambio;
    private Material textura_fondo;
    // Start is called before the first frame update
    void Start()
    {
        textura_fondo = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        tasa_de_cambio+=(Time.deltaTime*vel_desplazamiento)/10f;
        textura_fondo.SetTextureOffset("_MainTex", new Vector2(tasa_de_cambio,0));
    }
}
