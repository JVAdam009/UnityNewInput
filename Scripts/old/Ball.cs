using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Ball : MonoBehaviour
{
    private BallInputAction _input;

    private BallInputAction.BallActions _ball;

    [SerializeField] private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _input = new BallInputAction();
        _ball = _input.Ball;
        _ball.Enable();

        _ball.Bounce.performed += Bounce;
        
    }

    private void Bounce(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction.GetType() == typeof(TapInteraction)) // or (ctx.interaction is TapInteraction)
        {
            _rb.AddForce(Vector3.up,ForceMode.Impulse);
            
        } else if (ctx.interaction.GetType() == typeof(TapInteraction)) // or (ctx.interaction is HoldInteraction)
        {
            _rb.AddForce(10 *Vector3.up,ForceMode.Impulse);
        }
        else
        {
            _rb.AddForce(Vector3.up * 2.5f,ForceMode.Impulse);
        } 
    }
}
