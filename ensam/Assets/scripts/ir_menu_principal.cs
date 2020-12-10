using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ir_menu_principal : MonoBehaviour
{
    public void coger_para_menu_principal(string menu_principal){
        SceneManager.LoadScene(menu_principal);
    }
}
