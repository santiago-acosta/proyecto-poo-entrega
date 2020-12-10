using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proy_en_ol3 : MonoBehaviour
{
    public GameObject origen_ene;
    public float vel_proyectil_enem;
    private Vector3 inicio_en;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.gameObject.CompareTag("proy1")){
            transform.position=new Vector3(origen_ene.transform.position.x,origen_ene.transform.position.y+0.55f,origen_ene.transform.position.z);
        }
        else if(gameObject.gameObject.CompareTag("proy2")){
            transform.position=new Vector3(origen_ene.transform.position.x,origen_ene.transform.position.y-0.55f,origen_ene.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>-9.23){
            transform.Translate(vel_proyectil_enem,0f,0f);
        }
        else if(transform.position.x<=9.23 && (gameObject.tag=="proy1" || gameObject.tag=="proy2")){
            Destroy(gameObject);
        }
    }
}