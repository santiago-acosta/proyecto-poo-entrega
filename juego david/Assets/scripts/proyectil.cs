using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public GameObject origen;
    public float vel_proyectil;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.gameObject.CompareTag("proyec_temp")){
            transform.position=origen.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<9.98){
            transform.Translate(vel_proyectil,0f,0f);
        }
        else if(transform.position.x>=9.98 && gameObject.tag=="proyec_temp"){
            Destroy(gameObject);
        }
    }
}
