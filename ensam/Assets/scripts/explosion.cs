using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class explosion : MonoBehaviour
{
    int maximo;
    // Start is called before the first frame update
    void Start()
    {
        maximo=0;
    }

    // Update is called once per frame
    void Update()
    {
        maximo++;
        if(gameObject.tag=="muerte_jug" && maximo>30){
            SceneManager.LoadScene("game_over");
        }
        if(maximo>720){
            if(gameObject.tag=="muerte"){
            Destroy(gameObject);
            }
            maximo=0;
        }
    }
}
