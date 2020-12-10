using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalasJefe : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Jefe, explosionBala;
    private Transform Explosion;
    
    void OnCollisionEnter2D(Collision2D colision){
        if (colision.gameObject.tag=="Jugador"){
            Destroy(this.gameObject);
            Destroy(colision.gameObject);
            Explosion=Instantiate(explosionBala, transform.position,  transform.rotation);
            Explosion.tag="ClonExplosion";
            SceneManager.LoadScene("game_over");
            Debug.Log("BALA DESTRUIDA");
        }
        if (colision.gameObject.tag=="Jefe"){
            Physics.IgnoreCollision(colision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            Debug.Log("Toco al jefe");
        }
        if (colision.gameObject.tag=="Balas"){
            Physics.IgnoreCollision(colision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            Debug.Log("Toco la bala");
        }
        if (colision.gameObject.tag=="proyec_temp"){
            Physics.IgnoreCollision(colision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            Debug.Log("Toco la bala del jugador");
        }
    }
    
   

    // Update is called once per frame
    
}