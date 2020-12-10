using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    private float tiempo_despues_exploto;
    void Start()
    {
        tiempo_despues_exploto=0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_despues_exploto ++;
        if (this.gameObject.tag=="ClonExplosion") 
            if(tiempo_despues_exploto>=180)
                Destroy(this.gameObject);  
    }
}
