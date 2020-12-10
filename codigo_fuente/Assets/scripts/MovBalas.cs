using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MovBalas : MonoBehaviour
{
    // Start is called before the first frame update
    public float VelocidadBala;
    public Transform explosionBala;
    public Image Salud;
    private Transform Explosion;
    void Start(){
        if (Salud.fillAmount<=0.4){
            VelocidadBala *= 1.2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.left * VelocidadBala * Time.deltaTime);
        if(this.transform.position.x<=-11 && this.gameObject.tag=="Bala_Clon"){
            Destroy(this.gameObject);
            Explosion=Instantiate(explosionBala, transform.position,  transform.rotation);
            Explosion.tag="ClonExplosion";
            Debug.Log("BALA DESTRUIDA");  
        }
    }
}
