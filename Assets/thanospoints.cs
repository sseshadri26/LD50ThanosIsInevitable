using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class thanospoints : MonoBehaviour
{
    int thanosPoints;
    [SerializeField] public Text thanosPointsText;
    // Start is called before the first frame update
    void Start()
    {
        thanosPoints = 0;
    }

    // Update is called once per frame

    public void AddThanosPoint()
    {
        thanosPoints ++;
        thanosPointsText.text = "thanospoints™️: " + thanosPoints;
    }
}
