using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comp_1 : MonoBehaviour
{
    private int contador=0;
    public int max=3000;
    private float disx,disy,unix,uniy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(contador<max){
            contador+=1;
        }
        else if(contador==max){
            contador=0;
        }
        if(transform.position.x>7.81f){
            transform.Translate(-0.01f,0f,0f);
        }
        if(transform.position.x==7.81f && transform.position.y==3.96f){
            disx=(Mathf.Abs(7.81f-5.34f));
            disy=(Mathf.Abs(3.96f-2.03f));
            unix=(disx/(max/10));
            uniy=(disy/(max/10));
            transform.Translate(-unix,-uniy,0f);
        }
        if(transform.position.x<7.81f && transform.position.y<3.96 && transform.position.x>2.02f && transform.position.y<4.03f){
            transform.Translate(-unix,-uniy,0f);
        }
        if(transform.position.x==2.02 && transform.position.y==4.03f){
            disx=(Mathf.Abs(5.34f-2.02f));
            disy=(Mathf.Abs(2.03f-4.03f));
            unix=(disx/(max/10));
            uniy=(disy/(max/10));
            transform.Translate(-unix,uniy,0f);
        }
        if(transform.position.x<2.02f && transform.position.y<4.03f && transform.position.x>-1.57f && transform.position.y<2.17f){
            transform.Translate(-unix,uniy,0f);
        }

    }
}
