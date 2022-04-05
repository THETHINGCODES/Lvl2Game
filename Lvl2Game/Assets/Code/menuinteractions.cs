using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
using UnityEngine.SceneManagement;// this namespace makes the magic, tho
 
 [RequireComponent(typeof(Collider))] //A collider is needed to receive clicks
 public class menuinteractions : MonoBehaviour {
     public UnityEvent interactEvent;
     private void OnMouseDown() {
         interactEvent.Invoke();
         
     }
 }