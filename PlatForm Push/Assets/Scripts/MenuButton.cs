using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{   
        public string LevelName;      
        public void OonClick()
        {
            SceneManager.LoadScene(LevelName);
        }   
}