using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientos : MonoBehaviour
{

    public Vector3 subir_y_bajar(Vector3 origen,Vector3 maximo,Vector3 actual,float duracion,float ciclo){
        float distancia_tot,aumento,partes;
        Vector3 n_posicion;
        distancia_tot=4*(Mathf.Abs(origen.y-maximo.y));
        aumento=distancia_tot/(duracion*60);
        partes=(duracion*60)/4;
        if(ciclo<partes){
            n_posicion=new Vector3(actual.x,actual.y+aumento,actual.z);
            return n_posicion;
        }
        else if(ciclo>=partes && ciclo<partes*2){
            n_posicion=new Vector3(actual.x,actual.y-aumento,actual.z);
            return n_posicion;
        }
        else if(ciclo>=partes*2 && ciclo<partes*3){
            n_posicion=new Vector3(actual.x,actual.y-aumento,actual.z);
            return n_posicion;
        }
        else{
            n_posicion=new Vector3(actual.x,actual.y+aumento,actual.z);
            return n_posicion;
        }
    }
    public Vector3 punto_A_punto_B(Vector3 punto_A,Vector3 punto_B,Vector3 actual2,float duracion2){
        float disx,disy,aumenx,aumeny;
        Vector3 nu_posicion;
        disx=Mathf.Abs(punto_A.x-punto_B.x);
        disy=Mathf.Abs(punto_A.y-punto_B.y);
        aumenx=disx/(duracion2*60);
        aumeny=disy/(duracion2*60);
        if(punto_A.x<punto_B.x && punto_A.y>punto_B.y){
            nu_posicion=new Vector3(actual2.x+aumenx,actual2.y-aumeny,actual2.z);
            if(actual2.x>punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            else if(actual2.x>punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(punto_B.x,actual2.y-aumeny,actual2.z);
            }
            else if(actual2.x<punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(actual2.x+aumenx,punto_B.y,actual2.z);
            }
            return nu_posicion;
        }
        else if(punto_A.x==punto_B.x && punto_A.y>punto_B.y){
            nu_posicion=new Vector3(actual2.x,actual2.y-aumeny,actual2.z);
            if(actual2.y<punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            return nu_posicion;            
        }
        else if(punto_A.x>punto_B.x && punto_A.y>punto_B.y){
            nu_posicion=new Vector3(actual2.x-aumenx,actual2.y-aumeny,actual2.z);
            if(actual2.x<punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            else if(actual2.x>punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(actual2.x-aumenx,punto_B.y,actual2.z);
            }
            else if(actual2.x<punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(punto_B.x,actual2.y-aumeny,actual2.z);
            }
            return nu_posicion;
        }
        else if(punto_A.x<punto_B.x && punto_A.y==punto_B.y){
            nu_posicion=new Vector3(actual2.x+aumenx,actual2.y,actual2.z);
            if(actual2.x>punto_B.x){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            return nu_posicion;
        }
        else if(punto_A.x>punto_B.x && punto_A.y==punto_B.y){
            nu_posicion=new Vector3(actual2.x-aumenx,actual2.y,actual2.z);
            if(actual2.x<punto_B.x){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            return nu_posicion;
        }
        else if(punto_A.x<punto_B.x && punto_A.y<punto_B.y){
            nu_posicion=new Vector3(actual2.x+aumenx,actual2.y+aumeny,actual2.z);
            if(actual2.x>punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            else if(actual2.x>punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(punto_B.x,actual2.y+aumeny,actual2.z);
            }
            else if(actual2.x<punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(actual2.x+aumenx,punto_B.y,actual2.z);
            }
            return nu_posicion;
        }
        else if(punto_A.x==punto_B.x && punto_A.y<punto_B.y){
            nu_posicion=new Vector3(actual2.x,actual2.y+aumeny,actual2.z);
            if(actual2.y>punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            return nu_posicion;            
        }
        else if(punto_A.x>punto_B.x && punto_A.y<punto_B.y){
            nu_posicion=new Vector3(actual2.x+aumenx,actual2.y+aumeny,actual2.z);
            if(actual2.x<punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(punto_B.x,punto_B.y,actual2.z);
            }
            else if(actual2.x<punto_B.x && actual2.y<punto_B.y){
                nu_posicion=new Vector3(punto_B.x,actual2.y+aumeny,actual2.z);
            }
            else if(actual2.x>punto_B.x && actual2.y>punto_B.y){
                nu_posicion=new Vector3(actual2.x+aumenx,punto_B.y,actual2.z);
            }
            return nu_posicion;            
        }
        else if(actual2==punto_B){
            return actual2;
        }
        return new Vector3(0f,0f,0f);
    }
    
    public Vector3 curva_de_bezier_4(Vector3 p0,Vector3 p1,Vector3 p2,Vector3 p3,float duracion3,float ciclo2){
        Vector3 nue_posicion;
        float t;
        t=(1.0f/(duracion3*60))*ciclo2;
        nue_posicion=((p0*Mathf.Pow((1-t),3))+3*p1*t*Mathf.Pow((1-t),2)+3*p2*Mathf.Pow(t,2)*(1-t)+p3*Mathf.Pow(t,3));
        return nue_posicion;
    }

}
