using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using UnityEditor;

using UnityEngine.Events;

//Use dialogboxes

using UnityEngine.EventSystems;

using System.Threading.Tasks;


public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update

    //take in 2 game objects (panel 1 and 2), and a textmesh
    public GameObject panel1;
    public GameObject panel2;
    public Text time;

    public thanospoints thanosPoints;
    public Text endText;


    static float timer = 599;

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
            endText.text = "HAHAHAHA YOU DIED AND ONLY GOT " + thanosPoints.thanosPoints + " THANOSPOINTS™️! \n*DEFAULT DANCES*";
            panel2.SetActive(true);
        }

    }

    //method to set timer to 0
    public void resetTimer()
    {
        timer = 0;
    }


    [RuntimeInitializeOnLoadMethod]
    static void RunOnStart()
    {
        Application.wantsToQuit += WantsToQuit;
    }

    public static bool quitConfirmation = false;

    static bool WantsToQuit()
    {
        timer = 0;
        Debug.Log(Application.isEditor);
        if (Application.isEditor)
        {
            // Will get called only when playing in Editor mode
            Application.Quit();
            return true;
        }
        else if (quitConfirmation)
        {
            return true;
        }
        else
        {
            RequestQuitConfirmation();
        }
        return false;
    }

    static void RequestQuitConfirmation()
    {

        //bool result = EditorUtility.DisplayDialog("Thanos just won you clown.",
        //"Thanos just won you clown. Want to exit now?", "Yes", "No");

        //if (result)
        //{
        //    quitConfirmation = true;
        //    Application.Quit();
        //}
    }

}
