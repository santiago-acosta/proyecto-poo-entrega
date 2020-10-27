using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float velmov, cadencia_tiro;
    private float prox_disp;
    public GameObject proyec;
    private GameObject temp;
    private bool seguir_vivo=true;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(proyec.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D colision){
        if(colision.gameObject.tag=="enemigo" || colision.gameObject.tag==""){
            ;
        }
        
        Debug.Log("colision");
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && Time.time>prox_disp && seguir_vivo==true){
            prox_disp=Time.time+cadencia_tiro;
            temp=Instantiate(proyec);
            temp.tag="proyec_temp";
            Instantiate(temp);
        }
        if(proyec.transform.position.x>=9.98){
            Destroy(temp);
        }
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f && seguir_vivo==true)
        {
            if(transform.position.x>=-8.32f && transform.position.x<=8.29f){
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")* velmov * Time.deltaTime, 0f, 0f));
            }
            else if(transform.position.x<-8.32f){
                transform.Translate(0.1f,0f,0f);
            }
            else if(transform.position.x>8.29f){
                transform.Translate(-0.1f,0f,0f);
            }
        }
        
        if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f && seguir_vivo==true){
            if(transform.position.y>=-4.44f && transform.position.y<=4.49f){
                transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical")* velmov * Time.deltaTime, 0f));
            }
            else if(transform.position.y<-4.44f){
                transform.Translate(0f,0.1f,0f);
            }
            else if(transform.position.y>4.49f){
                transform.Translate(0f,-0.1f,0f);
            }
        }
    }
}
