using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Loader : MonoBehaviour
{
    public int LevelToLoad;
    public bool ToNextRoom=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ToNextRoom=true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ToNextRoom = false;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (ToNextRoom)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ToNextRoom=false;
                SceneManager.LoadScene(LevelToLoad);
            }
        }
    }
}
