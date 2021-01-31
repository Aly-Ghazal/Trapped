using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserNameActivator : MonoBehaviour
{
    public GameObject TextToInteractWith;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void GoToUserName()
    {
        TextToInteractWith.SetActive(true);

    }
    
}
