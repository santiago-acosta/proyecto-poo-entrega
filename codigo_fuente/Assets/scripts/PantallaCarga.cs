using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaCarga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.MakeTheLoad("nivel_1"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MakeTheLoad(string nivel)
    {
        yield return new WaitForSeconds(1f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(nivel);
        while (operation.isDone == false)
        {
            yield return null;
        }
    }
}
