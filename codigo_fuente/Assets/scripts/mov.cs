using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mov : MonoBehaviour
{
    public float velmov, cadencia_tiro;
    private float prox_disp;
    public GameObject proyec,anim_muerte;
    private GameObject temp,explotando;
    private bool seguir_vivo;
    public bool ol_1,ol_2;
    public int en_vivos,cant_oleada_1,cant_oleada_2;
    private int pruebas;
    // Start is called before the first frame update
    void Start()
    {
        cant_oleada_1=5;
        cant_oleada_2=5;
        seguir_vivo=true;
        ol_1=false;
        ol_2=false;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D colision){
        if(colision.gameObject.tag=="proyec_en_temp" && seguir_vivo==true || colision.gameObject.tag=="enemigo" && seguir_vivo==true || colision.gameObject.tag=="proy1" && seguir_vivo==true || colision.gameObject.tag=="proy2" && seguir_vivo==true){
            explotando=Instantiate(anim_muerte);
            explotando.tag="muerte_jug";
            explotando.transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z);
            seguir_vivo=false;
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        if(cant_oleada_1==0){
            ol_1=true;
        }
        if(cant_oleada_2==0){
            ol_2=true;
        }
        if(en_vivos==0){
            SceneManager.LoadScene("jefe");
        }
        if(Input.GetKey(KeyCode.Space) && Time.time>prox_disp && seguir_vivo==true){
            pruebas++;
            prox_disp=Time.time+cadencia_tiro;
            temp=Instantiate(proyec);
            temp.tag="proyec_temp";
        }
        if(Input.GetAxisRaw("Horizontal") > 0.5f && seguir_vivo==true || Input.GetAxisRaw("Horizontal") < -0.5f && seguir_vivo==true)
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
        
        if(Input.GetAxisRaw("Vertical") > 0.5f && seguir_vivo==true || Input.GetAxisRaw("Vertical") < -0.5f && seguir_vivo==true){
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
