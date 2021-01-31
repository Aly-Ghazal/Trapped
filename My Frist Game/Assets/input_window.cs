using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input_window : MonoBehaviour
{

    private void Awake()
    {
        //Hide();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
