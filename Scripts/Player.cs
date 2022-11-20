using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _input;

    private PlayerInputActions.PlayerActions _player;

    private PlayerInputActions.DrivingActions _drive;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputActions();
        _player = _input.Player;
        _drive = _input.Driving;
        
        _player.Enable();

        _player.Switch.performed += Switch;
    }

    private void Switch(InputAction.CallbackContext obj)
    {
        _player.Disable();
        
        _drive.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(_drive.Move.ReadValue<Vector2>().x,0,_drive.Move.ReadValue<Vector2>().y);
        
        transform.Translate(move * Time.deltaTime * 5);
    }
}
