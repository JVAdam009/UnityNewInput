using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _input;

    private PlayerInputActions.PlayerActions _actions;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputActions();
        
        _actions = _input.Player;
        _actions.Enable();

        //_actions.Move.performed += Move;
    }

    private void Update()
    {
        //poll inputs
        var move = _actions.Move.ReadValue<Vector2>();
        
        transform.Translate(new Vector3(move.x, 0,move.y)*Time.deltaTime*5);
            //transform.Translate(move * Time.deltaTime * 5);
    }

    private void Move(InputAction.CallbackContext ctx)
    {
        Debug.Log($"X:  {ctx.ReadValue<Vector2>().x} Y: {ctx.ReadValue<Vector2>().y} ");
        var move = ctx.ReadValue<Vector2>();
        
        transform.Translate(move * 5 * Time.deltaTime);
    }
}
