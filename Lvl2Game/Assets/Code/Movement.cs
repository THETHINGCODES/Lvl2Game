using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movements : MonoBehaviour
{
    Rigidbody rb;
    Vector2 _movePlayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    void OnMove(InputValue iv)
    {
        _movePlayer = iv.Get<Vector2>();
    }
   
   
    void OnFire()
    {
        Debug.Log("Boom, Bang, Blam!");
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(_movePlayer.x, 0.0f, _movePlayer.y);
        rb.AddForce(movement * 1.0f);
    }
}