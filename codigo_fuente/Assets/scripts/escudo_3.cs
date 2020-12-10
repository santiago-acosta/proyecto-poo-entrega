using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escudo_3 : MonoBehaviour
{
    public GameObject enemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigo.GetComponent<en_oleada_3>().siga2==false){
            transform.position=new Vector3(enemigo.transform.position.x,enemigo.transform.position.y,0f);
        }
        else {
            Destroy(gameObject);
        }
        
    }
}
