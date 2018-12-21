using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Border : MonoBehaviour
{
    public string levelToLoad1;
    public string levelToLoad2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player1")
        {
            SceneManager.LoadScene(levelToLoad1);
           
        }
        if(other.tag == "Player2")
        {
            SceneManager.LoadScene(levelToLoad2);
           
        }
    }
}
