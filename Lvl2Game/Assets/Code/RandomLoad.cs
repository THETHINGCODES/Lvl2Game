 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class SceneAdvance
 {
     private List<int> scenarios ;
 
     private static SceneAdvance instance;
 
     private SceneAdvance()
     {
         scenarios = new List<int> { 1, 2, 3 };
     }
 
     public static SceneAdvance Instance
     {
         get => instance == null ? ( instance = new SceneAdvance() ) : instance;
     }
 
     public void LoadNextScene()
     {
         if (scenarios.Count == 0)
             return;
         int randomIndex = UnityEngine.Random.Range(0, scenarios.Count);
         int currentScenario = scenarios[randomIndex];
         scenarios.RemoveAt(randomIndex);
         SceneManager.LoadScene(currentScenario);
     }
 }