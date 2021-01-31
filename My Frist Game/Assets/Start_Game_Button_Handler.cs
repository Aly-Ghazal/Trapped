using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Start_Game_Button_Handler : MonoBehaviour
{
    public static int LevelToLoad=0;
    public void LoadRoom0()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
