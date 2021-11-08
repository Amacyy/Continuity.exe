using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    void start()
    {


    }

    void update()
    {

    }

    public void Play()
    {
        Application.LoadLevel("Credits");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 1;
        }
    }
}