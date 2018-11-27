using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    float timer = 0f;
    static GameManager instance;
    public static GameManager Instance
    {
        get { return Instance ?? ((instance = new GameManager())); }
    }
    public Character Mycharacter
    {
        get;set;
    }
    private GameManager()
    {
        Object.DontDestoryOnLoad(new GameObject("updater", typeof(updater)));
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    class updater : MonoBehaviour
    {
        private void Update()
        {
            Instance.Update();
        }
    }
}
