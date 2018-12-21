using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    public int ID { get; set; }
    public string LevelName;
    public bool Completed { get; set; }
    public int Stars { get; set; }
    public bool Locked { get; set; }

    public Level(int id, string levelName, bool completed, int stars, bool locked)
    {
        this.ID = id;
        this.LevelName = LevelName;
        this.Completed = completed;
        this.Stars = stars;
        this.Locked = locked;
    }

    public void Complete()
    {
        this.Completed = true;
    }

    public void Complete(int stars)
    {
        this.Completed = true;
        this.Stars = stars;
    }
    public void Lock()
    {
        this.Locked = true;
    }
    public void Unlock()
    {
        this.Locked = false;
    }
    public void OonClick()
    {
        SceneManager.LoadScene(LevelName);
    }
}
