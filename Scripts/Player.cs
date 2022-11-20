using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private PlayerInputActions _input;

    private PlayerInputActions.PlayerActions _player;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputActions();
        _player = _input.Player;
        _player.Enable();

        _player.RandomColor.performed+= ChangeColor;
    }

    private void ChangeColor(InputAction.CallbackContext ctx)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
