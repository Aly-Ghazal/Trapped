using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public Text TimerText;
    [SerializeField] public float timeRemaining;

    void start()
    {
        TimerText.text = timeRemaining.ToString("0.00"); ;
    }


    void Update()
    {
        TimerText.text = timeRemaining.ToString("0.00"); ;
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            Debug.Log("Time has run out!");
        }
    }

}
