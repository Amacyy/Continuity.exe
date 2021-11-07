using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void start()
    {


    }

    void update()
    {

    }

    public void Play()
    {
        Application.LoadLevel("Level 1");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 1;
        }
    }
}