using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Player _player;

    private PlayerInputAction _input;
    // Start is called before the first frame update
    void Start()
    {
        InitInput();
    }

    void InitInput()
    {
        _input = new PlayerInputAction();
        _input.Player.Enable();
        _input.Player.Fire.performed += Fire_Performed;
    }

    private void Fire_Performed(InputAction.CallbackContext ctx)
    {
        _player.Fire();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerMovement = _input.Player.Movement.ReadValue<Vector2>();
        _player.Move(playerMovement);
    }
}
