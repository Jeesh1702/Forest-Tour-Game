using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    public GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if(PopUp.activeSelf == false)
        {
            PopUp.SetActive(true);
        }
        else
        {
            PopUp.SetActive(false);
        }
        // PopUp.SetActive(true);
        // Debug.Log("Clicked");
    }
}
