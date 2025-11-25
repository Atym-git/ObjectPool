using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener
{
    private InputAction _shootAction;
    private MainInputSystem _mainInputSystem;

    public InputListener()
    {
        Bind();
    }

    private void Bind()
    {
        _mainInputSystem = new();
        _shootAction = _mainInputSystem.Player.Attack;
        _shootAction.performed += Shoot;
    }

    private void Shoot(InputAction.CallbackContext obj)
    {
        
    }
}
