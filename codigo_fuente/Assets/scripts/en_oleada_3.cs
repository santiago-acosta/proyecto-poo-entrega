using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en_oleada_3 : MonoBehaviour
{
    public Vector3 inicio,final,final2,p_arrib,p_abaj;
    public float dura1,dura2,dura3,dura4,espe1,espe2,cad_tiro,desfa;
    public comportamientos com1;
    public GameObject proyec1,proyec2,anim_muerte;
    public bool siga2;
    private float acum,fueg1,fueg2;
    private float conti1_1,conti1_2,conti1_3,conti1_4,conti1_5,conti1_6,conti1_7,conti1_8;
    private float conti2_1,conti2_2,conti2_3,conti2_4,conti2_5,conti2_6,conti2_7,conti2_8;
    private bool pare,siga,osci,alter,arran,defi;
    private GameObject jugador,proy1,proy2,explo;

    // Start is called before the first frame update
    void Start()
    {
        conti1_1=Time.time+1000000000000;
        conti1_2=Time.time+1000000000000;
        conti1_3=Time.time+1000000000000;
        conti1_4=Time.time+1000000000000;
        conti1_5=Time.time+1000000000000;
        conti1_6=Time.time+1000000000000;
        conti1_7=Time.time+1000000000000;
        conti1_8=Time.time+1000000000000;
        conti2_1=Time.time+1000000000000;
        conti2_2=Time.time+1000000000000;
        conti2_3=Time.time+1000000000000;
        conti2_4=Time.time+1000000000000;
        conti2_5=Time.time+1000000000000;
        conti2_6=Time.time+1000000000000;
        conti2_7=Time.time+1000000000000;
        conti2_8=Time.time+1000000000000;
        arran=false;
        jugador=GameObject.Find("jugador");
        alter=false;
        osci=false;
        siga=false;
        siga2=false;
        pare=false;
        acum=0;
        defi=true;
    }

    void OnCollisionEnter2D(Collision2D colision){
        if(colision.gameObject.tag=="proyec_temp" && siga2==true){
            Destroy(colision.gameObject);
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
            if(jugador.GetComponent<mov>().ol_2==true){
                arran=true;
            }
        }
        if(siga2==true && defi==true){
            defi=false;
            if(gameObject.name=="enemigo_3_1"){
                fueg1=Time.time+cad_tiro;
                fueg2=Time.time+cad_tiro+(2*desfa);
            }
            else if(gameObject.name=="enemigo_3_2"){
                fueg1=Time.time+cad_tiro+(2*desfa);
                fueg2=Time.time+cad_tiro+(3*desfa);
            }
            else if(gameObject.name=="enemigo_3_3"){
                fueg1=Time.time+cad_tiro+(3*desfa);
                fueg2=Time.time+cad_tiro+(4*desfa);
            }
            else if(gameObject.name=="enemigo_3_4"){
                fueg1=Time.time+cad_tiro+(4*desfa);
                fueg2=Time.time+cad_tiro+(5*desfa);
            }
            else if(gameObject.name=="enemigo_3_5"){
                fueg1=Time.time+cad_tiro+(5*desfa);
                fueg2=Time.time+cad_tiro+(6*desfa);
            }
            else if(gameObject.name=="enemigo_3_6"){
                fueg1=Time.time+cad_tiro+(6*desfa);
                fueg2=Time.time+cad_tiro+(7*desfa);
            }
            else if(gameObject.name=="enemigo_3_7"){
                fueg1=Time.time+cad_tiro+(7*desfa);
                fueg2=Time.time+cad_tiro+(8*desfa);
            }
            else if(gameObject.name=="enemigo_3_8"){
                fueg1=Time.time+cad_tiro+(8*desfa);
                fueg2=Time.time+cad_tiro+(9*desfa);
            }
        }

        if(gameObject.transform.position==final && siga2==true && arran==true){
            alter=false;
        }

        if(gameObject.transform.position==final2 && siga2==true && arran==true){
            alter=true;
        }

        if(gameObject.name=="enemigo_3_1"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_1=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_1 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false && arran==true){
                osci=true;
                conti2_1=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_1 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }

        }
        if(gameObject.name=="enemigo_3_2"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_2=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_2 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_2=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_2 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_3"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_3=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_3 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_3=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_3 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_4"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_4=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_4 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_4=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_4 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_5"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_5=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_5 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_5=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_5 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_6"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_6=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_6 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_6=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_6 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_7"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_7=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_7 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false  && siga==true && arran==true){
                osci=true;
                conti2_7=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_7 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(gameObject.name=="enemigo_3_8"){
            if(gameObject.transform.position==final && pare==false && arran==true){
                pare=true;
                conti1_8=Time.time+espe1;
            }
            else if(pare==true && Time.time>conti1_8 && siga==false && arran==true){
                siga=true;
            }
            if(gameObject.transform.position==final2 && osci==false && siga==true && arran==true){
                osci=true;
                conti2_8=Time.time+espe2;
            }
            else if(osci==true && Time.time>conti2_8 && siga2==false && arran==true){
                siga2=true;
                alter=true;
            }
            if(gameObject.transform.position!=final && pare==false && arran==true){
                transform.position=com1.punto_A_punto_B(inicio,final,gameObject.transform.position,dura1);
            }
            else if(siga==true && siga2==false && arran==true && osci==false){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura2);
            }
            else if(siga2==true && alter==true && arran==true){
                transform.position=com1.punto_A_punto_B(final2,final,gameObject.transform.position,dura3);
            }
            else if(siga2==true && alter==false && arran==true){
                transform.position=com1.punto_A_punto_B(final,final2,gameObject.transform.position,dura4);
            }
        }
        if(siga2==true && Time.time>fueg1){
            if(gameObject.name=="enemigo_3_1"){
                fueg1=Time.time+cad_tiro;
            }
            else if(gameObject.name=="enemigo_3_2"){
                fueg1=Time.time+cad_tiro+(2*desfa);
            }
            else if(gameObject.name=="enemigo_3_3"){
                fueg1=Time.time+cad_tiro+(3*desfa);
            }
            else if(gameObject.name=="enemigo_3_4"){
                fueg1=Time.time+cad_tiro+(4*desfa);
            }
            else if(gameObject.name=="enemigo_3_5"){
                fueg1=Time.time+cad_tiro+(5*desfa);
            }
            else if(gameObject.name=="enemigo_3_6"){
                fueg1=Time.time+cad_tiro+(6*desfa);
            }
            else if(gameObject.name=="enemigo_3_7"){
                fueg1=Time.time+cad_tiro+(7*desfa);
            }
            else if(gameObject.name=="enemigo_3_8"){
                fueg1=Time.time+cad_tiro+(8*desfa);
            }
            proy1=Instantiate(proyec1);
            proy1.tag="proy1";
        }
        if(siga2==true && Time.time>fueg2){
            if(gameObject.name=="enemigo_3_1"){
                fueg2=Time.time+cad_tiro+(2*desfa);
            }
            else if(gameObject.name=="enemigo_3_2"){
                fueg2=Time.time+cad_tiro+(3*desfa);
            }
            else if(gameObject.name=="enemigo_3_3"){
                fueg2=Time.time+cad_tiro+(4*desfa);
            }
            else if(gameObject.name=="enemigo_3_4"){
                fueg2=Time.time+cad_tiro+(5*desfa);
            }
            else if(gameObject.name=="enemigo_3_5"){
                fueg2=Time.time+cad_tiro+(6*desfa);
            }
            else if(gameObject.name=="enemigo_3_6"){
                fueg2=Time.time+cad_tiro+(7*desfa);
            }
            else if(gameObject.name=="enemigo_3_7"){
                fueg2=Time.time+cad_tiro+(8*desfa);
            }
            else if(gameObject.name=="enemigo_3_8"){
                fueg2=Time.time+cad_tiro+(9*desfa);
            }
            proy2=Instantiate(proyec2);
            proy2.tag="proy2";
        }
    }
}
