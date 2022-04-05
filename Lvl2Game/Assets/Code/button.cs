using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
     if (GUI.Button (Rect (20,40,80,20), "Level 1")) {
         Application.LoadLevel ("scene1");
     }
}

