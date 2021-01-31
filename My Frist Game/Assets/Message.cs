using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{

    AudioSource welcomeMessageAudio;
    AudioClip welcomeMessageAudioClip;
    bool played;
    float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 5;
        played = false;
        welcomeMessageAudio =  GetComponent<AudioSource>();
        welcomeMessageAudioClip = welcomeMessageAudio.clip;
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

        }
        else if(!played)
        {
            welcomeMessageAudio.Play();
            played = true;
        }
        if (!welcomeMessageAudio.isPlaying && played)
        {
            Level_Loader.messageEnded = true;
        }
    }
}
