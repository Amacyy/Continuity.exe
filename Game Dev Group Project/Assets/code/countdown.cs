using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public string levelloaded;
    private float timer = 20f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            SceneManager.LoadScene(levelloaded);
        }
    }
}
