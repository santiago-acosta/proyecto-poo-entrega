using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trayectoria : MonoBehaviour
{
    [Range(4,10)]
    public int can_puntos=4;
    [SerializeField]
    private Transform[] p_ref;
    private Vector2 postrayec;
    private void OnDrawGizmos(){
        Gizmos.color=Color.yellow;
        for(float t=0;t<=1;t+=0.05f){
            postrayec=Mathf.Pow(1-t,3)*p_ref[0].position+
                3*Mathf.Pow(1-t,2)*t*p_ref[1].position+
                3*(1-t)*Mathf.Pow(t,2)*p_ref[2].position+
                Mathf.Pow(t,3)*p_ref[3].position;
            Gizmos.DrawSphere(postrayec,0.25f);
        }
        Gizmos.DrawLine(new Vector2(p_ref[0].position.x,p_ref[0].position.y),
            new Vector2(p_ref[1].position.x,p_ref[1].position.y));
        Gizmos.DrawLine(new Vector2(p_ref[2].position.x,p_ref[2].position.y),
            new Vector2(p_ref[3].position.x,p_ref[3].position.y));
    }

}
