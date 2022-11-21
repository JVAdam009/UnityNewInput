using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private ProgressBarInputAction _input;
    private bool _decreaseBar = false;
    private Coroutine Increase;
    void Start()
    {
        _input = new ProgressBarInputAction();
        _input.ProgressBar.Enable();

        _input.ProgressBar.Bar.performed += IncreaseBar;
        _input.ProgressBar.Bar.canceled += DecreaseBar;
    }

    private void DecreaseBar(InputAction.CallbackContext obj)
    {
        _decreaseBar = true;
    }

    private void IncreaseBar(InputAction.CallbackContext ctx)
    {
        _decreaseBar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_decreaseBar)
        {
            GetComponent<Slider>().value -= 1 * Time.deltaTime;
        }

        GetComponent<Slider>().value += _input.ProgressBar.Bar.ReadValue<float>() * Time.deltaTime;
    }

}
