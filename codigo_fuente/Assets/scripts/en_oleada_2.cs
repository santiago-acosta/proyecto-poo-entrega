using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en_oleada_2 : MonoBehaviour
{
    public float dura1,dura2;
    public Vector3 inicio,final,inicio2,final2;
    public Vector3 pn0,pn1,pn2,pn3,p0_2,p1_2,p2_2,p3_2,p1_3,p2_3;
    public comportamientos com;
    public float cad_tiro,espe;
    public GameObject proy_en,jugador,anim_muerte;
    public bool siga;
    private float dura2_2,cicl,cicl2,cicl2_1,acum,acum2,acum3,fueg,conti;
    private bool una_vez,alter,ini,lis,pare;
    private GameObject proy_ene,explo;
    // Start is called before the first frame update
    void Start()
    {
        siga=false;
        pare=false;
        ini=false;
        jugador=GameObject.Find("jugador");
        cicl=dura1*60;
        acum=0;
        cicl2=dura2*60;
        acum2=0;
        cicl2_1=cicl2/2;
        acum3=0;
        una_vez=true;
        alter=true;
        lis=true;
        dura2_2=dura2/2;
        fueg=Time.time+1000000000;
    }

    void OnCollisionEnter2D(Collision2D colision){
        if(colision.gameObject.tag=="proyec_temp" && ini==true && siga==true){
            Destroy(colision.gameObject);
            jugador.GetComponent<mov>().cant_oleada_2--;
            explo=Instantiate(anim_muerte);
            explo.tag="muerte";
            explo.transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z);
            jugador.GetComponent<mov>().en_vivos--;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("jugador") != null){
            if(jugador.GetComponent<mov>().ol_1==true && lis==true){
                ini=true;
                if(gameObject.name=="enemigo_2_4" || gameObject.name=="enemigo_2_5"){
                    fueg=Time.time+cad_tiro;
                }
                else if(gameObject.name=="enemigo_2_3"){
                    fueg=Time.time+cad_tiro+0.5f;
                }
                else if(gameObject.name=="enemigo_2_1" || gameObject.name=="enemigo_2_2"){
                    fueg=Time.time+cad_tiro+0.7f;
                }
                lis=false;
            }
        }
        if(acum>=cicl && ini==true){
            acum=0;
            una_vez=false;
        }
        if(una_vez==true && ini==true){
            acum++;
        }
        if(una_vez==false && ini==true && siga==true){
            acum2++;
        }
        if(acum2>=cicl2 && ini==true && siga==true){
            acum2=0;
        }
        if(acum2>=cicl2_1 && ini==true && siga==true){
            alter=false;
        }
        if(alter==false && ini==true && siga==true){
            acum3++;
        }
        if(acum3>=cicl2_1 && ini==true && siga==true){
            acum3=0;
            alter=true;
        }
        if(gameObject.name=="enemigo_2_1" && ini==true){
            if(una_vez==true){
                transform.position=com.curva_de_bezier_4(pn0,pn1,pn2,pn3,dura1,acum);
                if(acum==cicl){
                    pare=true;
                    conti=Time.time+espe;
                } 
            }
            else if(pare==true){
                if(Time.time>conti){
                    siga=true;
                    pare=false;
                }
            }
            else if(una_vez==false && siga==true){
                transform.position=com.subir_y_bajar(inicio2,final2,gameObject.transform.position,dura2,acum2);
            }
        }
        else if(gameObject.name=="enemigo_2_2" && ini==true){
            if(una_vez==true){
                transform.position=com.curva_de_bezier_4(pn0,pn1,pn2,pn3,dura1,acum);
                if(acum==cicl){
                    pare=true;
                    conti=Time.time+espe;
                } 
            }
            else if(pare==true){
                if(Time.time>conti){
                    siga=true;
                    pare=false;
                }
            }
            else if(una_vez==false && siga==true){
                transform.position=com.subir_y_bajar(inicio2,final2,gameObject.transform.position,dura2,acum2);
            }

        }
        else if(gameObject.name=="enemigo_2_3" && ini==true){
            if(una_vez==true){
                transform.position=com.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
                if(acum==cicl){
                    pare=true;
                    conti=Time.time+espe;
                }  
            }
            else if(pare==true){
                if(Time.time>conti){
                    siga=true;
                    pare=false;
                }
            }
            else if(una_vez==false && alter==true && siga==true){
                transform.position=com.curva_de_bezier_4(p0_2,p1_2,p2_2,p3_2,dura2_2,acum2);
            }
            else if(una_vez==false && alter==false && siga==true){
                transform.position=com.curva_de_bezier_4(p3_2,p1_3,p2_3,p0_2,dura2_2,acum3);
            }
        }
        else if(gameObject.name=="enemigo_2_4" && ini==true){
            if(una_vez==true){
                transform.position=com.curva_de_bezier_4(pn0,pn1,pn2,pn3,dura1,acum);
                if(acum==cicl){
                    pare=true;
                    conti=Time.time+espe;
                } 
            }
            else if(pare==true){
                if(Time.time>conti){
                    siga=true;
                    pare=false;
                }
            }
            else if(una_vez==false && siga==true){
                transform.position=com.subir_y_bajar(inicio2,final2,gameObject.transform.position,dura2,acum2);
            }
        }
        else if(gameObject.name=="enemigo_2_5" && ini==true){
            if(una_vez==true){
                transform.position=com.curva_de_bezier_4(pn0,pn1,pn2,pn3,dura1,acum);
                if(acum==cicl){
                    pare=true;
                    conti=Time.time+espe;
                } 
            }
            else if(pare==true){
                if(Time.time>conti){
                    siga=true;
                    pare=false;
                }
            }
            else if(una_vez==false && siga==true){
                transform.position=com.subir_y_bajar(inicio2,final2,gameObject.transform.position,dura2,acum2);
            }           
        }
        if(ini==true && Time.time>fueg && siga==true){
            if(gameObject.name=="enemigo_2_4" || gameObject.name=="enemigo_2_5"){
                fueg=Time.time+cad_tiro;
            }
            else if(gameObject.name=="enemigo_2_3"){
                fueg=Time.time+cad_tiro+0.5f;
            }
            else if(gameObject.name=="enemigo_2_1" || gameObject.name=="enemigo_2_2"){
                fueg=Time.time+cad_tiro+0.7f;
            }
            proy_ene=Instantiate(proy_en);
            proy_ene.tag="proyec_en_temp";
        }
    }
}
