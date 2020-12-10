using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escudo_1 : MonoBehaviour
{
    public GameObject enemigo;
    private string nomb;
    // Start is called before the first frame update
    void Start()
    {
        nomb=enemigo.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigo.GetComponent<en_seguidor>().trans_comp==false && GameObject.Find(nomb)!=null){
            transform.position=new Vector3(enemigo.transform.position.x,enemigo.transform.position.y,-0.1f);
        }
        else{
            Destroy(gameObject);
        }
    }
}
