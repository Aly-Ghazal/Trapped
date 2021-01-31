using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Loader : MonoBehaviour
{
    public GameObject PuzzleToBeSolved;
    public bool StartSolvePuzzle = false;

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

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (StartSolvePuzzle)
        {
            //if the player is in front of the puzzle door and press R
            //then Show the door's Puzzle
            if (Input.GetKeyDown(KeyCode.R))
            {
                StartSolvePuzzle = false;
                //load or acive your puzzle her
                PuzzleToBeSolved.SetActive(true);
            }
        }
    }
}
