using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class move1 : MonoBehaviour
{


	
   
 
    float _speed = -20.0f;
    float velocity;
    Vector2 _movementInputVector, _lookInputVector;
    CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
      _characterController = GetComponent<CharacterController>();  
      
    }
    void FixedUpdate()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        MovePlayer();


    }
    void MovePlayer()
    {
        Vector3 move = new Vector3(_movementInputVector.x, 0.0f, _movementInputVector.y);
        move = this.transform.TransformDirection(move);
        _characterController.SimpleMove(move * _speed);
    
       
    }

    void OnMove(InputValue iv)
    {
        _movementInputVector = iv.Get<Vector2>();
    }
    void OnLook(InputValue iv)
    {
        _lookInputVector = iv.Get<Vector2>();
    }
     void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("sceneend"))
        {
            Debug.Log("SceneEnd");
            SceneManager.LoadScene("scene2");
        }
       
        
    } 
    
}