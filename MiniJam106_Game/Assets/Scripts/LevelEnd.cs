using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("End level 1");
        SceneManager.LoadScene(2); 
    }
}
