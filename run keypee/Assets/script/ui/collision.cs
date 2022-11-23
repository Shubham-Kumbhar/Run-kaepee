using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
    {
        int a;
        void OnCollisionEnter() 
        {
        a = Random.Range(1, 3);
        SceneManager.LoadScene(a);
        }
    }
