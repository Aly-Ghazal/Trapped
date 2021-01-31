using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class ReadInput2 : MonoBehaviour
{
    [SerializeField] private GameObject die;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject hide;
    private string input;
    public AudioSource pass;

    // Start is called before the first frame update
    void Start()
    {
        
        
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(ReadStr);
        input.onEndEdit = se;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReadStr(string s)
    {

        if (s.ToLower().Contains("dream") )
        {
            
            pass.Play();
            hide.SetActive(false);
            PlayerMovement.freezed = false;
            win.SetActive(true);
            
        }

    }
}
