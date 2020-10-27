using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en_seguidor : MonoBehaviour
{
    [SerializeField]
    private Transform[] trayectorias;
    private int ruta_actual;
    private float t,velo,act,ini_disp;
    private Vector2 pos_en;
    private bool ruta_permitida,trans_comp=false,ini_esp=false,pare=false,deje=false;
    public float espe,cad_tiro;
    public GameObject proy_enem;
    private GameObject temp_en;

    // Start is called before the first frame update
    void Start()
    {
        ruta_actual=0;
        t=0f;
        velo=0.5f;
        ruta_permitida=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>7.81){
            transform.Translate(-0.01f,0f,0f);
        }
        else if(transform.position.x<=7.81 && pare==false){
            ini_esp=true;
            pare=true;
            act=Time.time+espe;
        }
        else if(ini_esp=true && Time.time>act && deje==false){
            trans_comp=true;
            ini_disp=Time.time+cad_tiro;
            deje=true;
        }
        if(Time.time>ini_disp){
            ini_disp=Time.time+cad_tiro;
            temp_en=Instantiate(proy_enem);
            temp_en.tag="proyec_en_temp";
            Instantiate(temp_en);;
        }
        if(ruta_permitida && trans_comp==true){
            StartCoroutine(seguir_ruta(ruta_actual));
        }

    }

    private IEnumerator seguir_ruta(int num_ruta){
        ruta_permitida=false;
        Vector2 p0=trayectorias[num_ruta].GetChild(0).position,p1=trayectorias[num_ruta].GetChild(1).position;
        Vector2 p2=trayectorias[num_ruta].GetChild(2).position,p3=trayectorias[num_ruta].GetChild(3).position;

        while(t<1){
            t+=Time.deltaTime*velo;
            pos_en=Mathf.Pow(1-t,3)*p0+3*Mathf.Pow(1-t,2)*t*p1+3*(1-t)*Mathf.Pow(t,2)*p2+Mathf.Pow(t,3)*p3;
            transform.position=pos_en;

            yield return new WaitForEndOfFrame();

        }
        t=0f;
        ruta_actual+=1;
        if(ruta_actual>trayectorias.Length-1){
            ruta_actual=0;
        }
        ruta_permitida=true;

    }
}
