using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public Text TimerText;
    [SerializeField] public float timeRemaining;
    public GameObject deadScene;
    void start()
    {
        deadScene.SetActive(false);
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
            PlayerMovement.freezed = false;
            deadScene.SetActive(true);

            Debug.Log("Time has run out!");
        }
    }

}
