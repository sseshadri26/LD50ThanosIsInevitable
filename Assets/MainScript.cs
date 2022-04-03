using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update

    //take in 2 game objects (panel 1 and 2), and a textmesh
    public GameObject panel1;
    public GameObject panel2;
    public Text time;

    [SerializeField]
    float timer = 10;

    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        int minutes = ((int)timer % 3600) / 60;
        int seconds = ((int)timer % 3600) % 60;
        if (seconds < 10)
        {
            time.text = minutes + ":0" + seconds;
        }
        else
        {
            time.text = minutes + ":" + seconds;
        }

        if (timer < 0)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }

    }

    //method to set timer to 0
    public void resetTimer()
    {
        timer = 0;
    }
}
