using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
             UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            
        }
    }
}
