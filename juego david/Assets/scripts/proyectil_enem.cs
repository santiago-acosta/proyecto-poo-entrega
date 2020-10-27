using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil_enem : MonoBehaviour
{
    public GameObject origen_ene;
    public float vel_proyectil_enem;
    private Vector3 inicio_en;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.gameObject.CompareTag("proyec_en_temp")){
            transform.position=origen_ene.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>-9.23){
            transform.Translate(vel_proyectil_enem,0f,0f);
        }
        else if(transform.position.x<=9.23 && gameObject.tag=="proyec_en_temp"){
            Destroy(gameObject);
        }
    }
}