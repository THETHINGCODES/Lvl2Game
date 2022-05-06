using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class colscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            Debug.Log("SceneEnd");
            // select random zone by name
            string[] zones = new string[5] { "scene1", "scene2", "scene3", "scene4", "scene5" };
            int random = Random.Range(0, 5);
            Application.LoadLevel(zones[random]);
        }
    }
}
