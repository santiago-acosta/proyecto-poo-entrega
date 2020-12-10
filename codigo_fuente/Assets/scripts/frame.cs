using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frame : MonoBehaviour
{
    public int obje;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(obje!=Application.targetFrameRate){
            Application.targetFrameRate=obje;
        }
    }
}
