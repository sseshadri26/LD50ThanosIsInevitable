using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class thanospoints : MonoBehaviour
{
    public int thanosPoints;
    [SerializeField] public Text thanosPointsText;

    [SerializeField] public Slider thanosSlider;
    [SerializeField] public GameObject slideCanvas;

    bool slideRight;
    // Start is called before the first frame update
    void Start()
    {
        thanosPoints = 0;
        slideRight = true;
    }

    // Update is called once per frame

    public void AddThanosPoint()
    {
        updateThanosPoints(1);
    }

    void updateThanosPoints(int points)
    {
        thanosPoints += points;
        thanosPointsText.text = "thanospoints™️: " + thanosPoints;
        if(thanosPoints > 50)
        {
            slideCanvas.SetActive(true);
        }
    }
    public void sliderPoints()
    {
        if(slideRight && thanosSlider.value == 1)
        {
            slideRight = !slideRight;
            updateThanosPoints(10);
        }
        else if (thanosSlider.value == 0)
        {
            slideRight = !slideRight;
            updateThanosPoints(5);
        }
    }
}
