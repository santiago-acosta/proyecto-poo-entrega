using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jefe : MonoBehaviour
{
    public Transform pos_jugador, punto1, punto2, punto3,punto4, explosion;
    public float velocidad,ini_dispa, freno;
    public GameObject jefe_anim_muerte;
    public GameObject[] bloques =new GameObject[7];
    private GameObject jefe_explotando;
    private bool vida_mayor1,vida_mayor2, entradaF2, entradaF3, muerte;
    private int vida_jefe, contador, contador2;
    public Image Salud;
    Random aleatorio;
    

    // Start is called before the first frame update
    void Start()
    {
        pos_jugador = GameObject.Find("jugador").transform;
        punto1 = GameObject.Find("punto1").transform;
        punto2 = GameObject.Find("punto2").transform;
        punto3 = GameObject.Find("punto3").transform;
        punto4 = GameObject.Find("punto4").transform;
        vida_jefe=7;
        vida_mayor1=false;
        entradaF2=true;
        entradaF3=true;
        muerte=false;
        contador=0;
        aleatorio= new Random();
    }

    // Update is called once per frame
    void Update()
    {   if (Salud.fillAmount>= 0.7)
    {
        if ((pos_jugador.position.y > this.transform.position.y)&&(this.transform.position.y<4.05))
            transform.Translate (Vector3.up * velocidad * Time.deltaTime);
        if ((pos_jugador.position.y < this.transform.position.y)&&(this.transform.position.y>-4.05))
            transform.Translate (-Vector3.up * velocidad * Time.deltaTime);
    }
        if (Salud.fillAmount>=0.4 && Salud.fillAmount<0.7){
            if (entradaF2==true){
                if(Vector2.Distance(transform.position, punto1.position)>freno)
                    transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*Time.deltaTime);
                else {entradaF2=false;
                Debug.Log("Moviendose a 2");} 
                }
            else{
                if (contador==0){
                    if(Vector2.Distance(transform.position, punto2.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto2.position, velocidad*2*Time.deltaTime);
                    else contador=1;
                }
                if (contador==1){
                    if(Vector2.Distance(transform.position, punto1.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*2*Time.deltaTime);
                    else contador=2;
                }
                if (contador==2){
                    if(Vector2.Distance(transform.position, punto4.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto4.position, velocidad*2*Time.deltaTime);
                    else contador=3;
                }
                if (contador==3){
                    if(Vector2.Distance(transform.position, punto1.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*2*Time.deltaTime);
                    else contador=0;
                }
            }
        }
        if (Salud.fillAmount<0.4){
            if (entradaF3==true){
                if(Vector2.Distance(transform.position, punto1.position)>freno)
                    transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*Time.deltaTime);
                else entradaF3=false;}
            else{
                if (contador==0){
                    if(Vector2.Distance(transform.position, punto2.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto2.position, velocidad*3*Time.deltaTime);
                    else contador=Random.Range(0,4);
                }
                if (contador==1){
                    if(Vector2.Distance(transform.position, punto3.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto3.position, velocidad*3*Time.deltaTime);
                    else contador=Random.Range(0,4);
                }
                if (contador==2){
                    if(Vector2.Distance(transform.position, punto4.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto4.position, velocidad*3*Time.deltaTime);
                    else contador=Random.Range(0,4);
                }
                if (contador==3){
                    if(Vector2.Distance(transform.position, punto1.position)>freno) transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*3*Time.deltaTime);
                    else contador=Random.Range(0,4);
                }
            }
        }
        if (Salud.fillAmount<=0&&muerte==false){
            Destroy(this.gameObject);
            muerte=true;
            Instantiate(explosion, transform.position, transform.rotation);
            SceneManager.LoadScene("game_over");
        }
    }
               /* if ((transform.position.x<=punto1.position.x+10||transform.position.x>=punto1.position.x-10) && (transform.position.y<=punto1.position.y+10||transform.position.y>=punto1.position.y-10))  {
                    entradaF2=false;
                    Debug.Log("Entre en fase 2");
                    Debug.Log("Muevase al punto 2");
                }
                
            }
            else{
                if (contador==0){
                    transform.position= Vector2.MoveTowards(transform.position,punto2.position, velocidad*   Time.deltaTime);
                    if ((transform.position.x<=punto2.position.x+10||transform.position.x>=punto2.position.x-10) && (transform.position.y<=punto2.position.y+10||transform.position.y>=punto2.position.y-10))  {
                    Debug.Log("Entre en fase 2.1");
                    Debug.Log("Muevase al punto 3");
                    contador=1;
                    }
                }
                if (contador==1){
                    transform.position= Vector2.MoveTowards(transform.position,punto3.position, velocidad*   Time.deltaTime);
                    if ((transform.position.x<=punto3.position.x+10||transform.position.x>=punto3.position.x-10) && (transform.position.y<=punto3.position.y+10||transform.position.y>=punto3.position.y-10))  {
                    Debug.Log("Entre en fase 2.2");
                    Debug.Log("Muevase al punto 4");
                    contador=2;
                    }
                }
                if (contador==2){
                    transform.position= Vector2.MoveTowards(transform.position,punto4.position, velocidad*   Time.deltaTime);
                    if ((transform.position.x<=punto4.position.x+10||transform.position.x>=punto4.position.x-10) && (transform.position.y<=punto4.position.y+10||transform.position.y>=punto4.position.y-10))  {
                    Debug.Log("Entre en fase 2.3");
                    Debug.Log("Muevase al punto 1");
                    contador=3;
                    }
                }
                if (contador==3){
                    transform.position= Vector2.MoveTowards(transform.position,punto1.position, velocidad*   Time.deltaTime);
                     if ((transform.position.x<=punto1.position.x+10||transform.position.x>=punto1.position.x-10) && (transform.position.y<=punto1.position.y+10||transform.position.y>=punto1.position.y-10))  {
                    Debug.Log("Entre en fase 2.4");
                    Debug.Log("Muevase al punto 2");
                    contador=0;
                    }
                }
                */ 
                
            
         
       
       /* else if (Salud.fillAmount < 0.7 && Salud.fillAmount>=0.4)
        {
            segundaFase = GetComponent<Animator>(); 
            segundaFase.SetFloat ("fillAmount", Salud.fillAmount);
            if(this.transform.position.y<=240&&(ataques==6||ataques==4))
            {
                transform.position += Vector3.up*velocidad*Time.deltaTime;
                if ((this.transform.position.y>=239.5)&&(ataques==6||ataques==4))
            {
                if(this.transform.position.x >=pos_jugador.position.x)
                transform.position += Vector3.left*velocidad*5*Time.deltaTime;
                ataques--;
            }
            }
            

            if(this.transform.position.y>=83&&(ataques==5||ataques==2))
            {
                transform.Translate(Vector3.down * 100 * Time.deltaTime);
                if (this.transform.position.y>=82.5&&(ataques==5||ataques==2))
                {
                    transform.Translate(Vector3.left * velocidad*5 * Time.deltaTime);
                    ataques--;
                }
            } 
            if(this.transform.position.y>=190&&(ataques==3||ataques==1))
            {
                transform.Translate(Vector3.down * 100 * Time.deltaTime);
                if (this.transform.position.y<=190.5&&(ataques==3||ataques==1))
                {
                    transform.Translate(Vector3.left * velocidad*5 * Time.deltaTime);
                    ataques--;
                }
            }
            if(this.transform.position.y<=190&&(ataques==3||ataques==1))
            {
                transform.Translate(Vector3.up * 100 * Time.deltaTime);
                if (this.transform.position.y>=189.5&&(ataques==3||ataques==1))
                {transform.Translate(Vector3.left * velocidad*5 * Time.deltaTime);
                ataques--;}
            }
            
            
        
        }*/
    









    
    void OnCollisionEnter2D(Collision2D colision){
        if(vida_mayor1==true){
            vida_mayor2=true;
        }
        if(colision.gameObject.tag=="proyec_temp"){
            vida_jefe--;
            Debug.Log("bajele 1");
            Destroy(colision.gameObject);
            Destroy(bloques[vida_jefe]);
        }
        if(colision.gameObject.tag=="proyec_temp" && vida_jefe==1){
            Debug.Log("bajele 1 y esta vaina es 2");
            vida_jefe--;
            vida_mayor1=true;
            Destroy(colision.gameObject);
            Destroy(bloques[vida_jefe]);
        }
        if(colision.gameObject.tag=="proyec_temp" && vida_mayor2==true){
            vida_jefe--;
            Debug.Log("me toteo de una porque si");
            jefe_explotando=Instantiate(jefe_anim_muerte);
            jefe_explotando.tag="muerte";
            Instantiate(jefe_explotando);
            jefe_explotando.transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z-1);
            Destroy(bloques[vida_jefe]);
            Destroy(gameObject);
        }
    }
}
