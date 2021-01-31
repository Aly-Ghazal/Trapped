using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Loader : MonoBehaviour
{
    public GameObject PuzzleToBeSolved;
    public bool StartSolvePuzzle = false;
    bool played;
    public AudioSource puzzleAudio;
    AudioClip puzzleAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        played = false;
        puzzleAudioClip = puzzleAudio.clip;

    }

    //if Player is In front of the puzzle door
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartSolvePuzzle = true;

        }
    }
    //if Player isn't In front of the puzzle door
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartSolvePuzzle = false;
            PuzzleToBeSolved.SetActive(false);
        }
    }

    


    // Update is called once per frame
    void Update()
    {
        if (StartSolvePuzzle)
        {
            //if the player is in front of the puzzle door and press R
            //then Show the door's Puzzle
            if (Input.GetKeyDown(KeyCode.R) && !played)
            {
                puzzleAudio.Play();
                played = true;
                PlayerMovement.freezed = true;
            }
            if(played && !puzzleAudio.isPlaying)
            {
                StartSolvePuzzle = false;
                PuzzleToBeSolved.SetActive(true);
            }
        }
        
    }
}
