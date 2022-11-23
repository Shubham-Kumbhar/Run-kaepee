using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loader", 5f);
    }
    void loader()
    {
            int a;
            a = Random.Range(1, 4);
            SceneManager.LoadScene(a);
        
    }
}
