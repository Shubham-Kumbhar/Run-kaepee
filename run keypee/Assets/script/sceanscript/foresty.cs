using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class foresty : MonoBehaviour
{
    int a;
    int b;
    int c;

    void OnCollisionEnter()
    {
        b = Random.Range(1, 4);
        c = Random.Range(1, 4);
        if (b == c)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            a = Random.Range(1, 3);
            if (a == 1)
                SceneManager.LoadScene(2);
            else
                SceneManager.LoadScene(3);
        }
    }
}

