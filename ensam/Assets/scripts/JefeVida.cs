using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class JefeVida : MonoBehaviour
{
    private float VidaJefe= 100;
    public float daño;
    public Image Salud;
    public Transform explosionBala;
    private Transform Explosion;
    

    // Update is called once per frame
    
    void Update(){
        VidaJefe = Mathf.Clamp(VidaJefe, 0, 100);
        Salud.fillAmount = VidaJefe/100;
    }
    
    void OnCollisionEnter2D(Collision2D colision){
        if (colision.gameObject.tag=="Jugador"){
            VidaJefe -=daño;
            Debug.Log("Jefe dañado");
        }
        if (colision.gameObject.tag=="proyec_original"){
            VidaJefe -=daño;
            Destroy(colision.gameObject);
            Explosion=Instantiate(explosionBala, colision.gameObject.transform.position,  transform.rotation);
            Explosion.tag = "ClonExplosion";
            Debug.Log("BALA DEL JUGADOR DESTRUIDA");
        }
        if (colision.gameObject.tag=="proyec_temp"){
            VidaJefe -=daño;
            Destroy(colision.gameObject);
            Explosion=Instantiate(explosionBala, colision.gameObject.transform.position,  transform.rotation);
            Explosion.tag = "ClonExplosion";
            Debug.Log("BALA DEL JUGADOR DESTRUIDA");
        }
        if (colision.gameObject.tag=="Balas"){
            Physics.IgnoreCollision(colision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            Debug.Log("Toco mis balas");
        }
    }
}
