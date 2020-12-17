using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction movementInputVector;
    public CharacterController controller; 
    public float speed = 100.0f;

    void Start(){
        controller = GetComponent<CharacterController>();
    } 
    void OnEnable(){
        movementInputVector.Enable();
    }
    void OnDisable(){
        movementInputVector.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = movementInputVector.ReadValue<Vector2>();
        new Vector3(inputVector.x,0,inputVector.y);
        controller.Move(inputVector*Time.deltaTime * speed);  
    }
}
