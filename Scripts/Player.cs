using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotate = new Vector3(0,0 ,_player.Rotate.ReadValue<float>());
        transform.Rotate(Rotate * (Time.deltaTime * 100));
    }
}
