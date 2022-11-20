using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    // get ref and start an instance to input actions
    // enable action map (dog)
    //register perform functions

    private PlayerInputActions _input;
    private PlayerInputActions.DogActions _Dog;

    private void Start()
    {
        _input = new PlayerInputActions();
        _input.Dog.Enable();
        _Dog = _input.Dog;

        _Dog.Bark.performed += Bark;
        _Dog.Bark.canceled += DoneBarking;

        _Dog.Run.started += RunStart;
        _Dog.Run.performed += IsRunning;
        _Dog.Run.canceled += DoneRunning;

        _Dog.Die.performed += Dead;

        _Dog.Walk.performed += Moving;


    }

    private void Moving(InputAction.CallbackContext obj)
    {
        Debug.Log("I'm moving " + obj.action.ToString());
    }

    private void Dead(InputAction.CallbackContext obj)
    {
        Debug.Log("I'm Dead");
    }

    private void DoneRunning(InputAction.CallbackContext obj)
    {
        Debug.Log("Done Running");
    }

    private void IsRunning(InputAction.CallbackContext obj)
    {
       Debug.Log("Running");
    }

    private void RunStart(InputAction.CallbackContext obj)
    {
        Debug.Log("Run Started");
    }

    private void DoneBarking(InputAction.CallbackContext obj)
    {
        Debug.Log("Done Barking");
    }

    private void Bark(InputAction.CallbackContext ctx)
    {
       Debug.Log("Bark");
    }
     
}
