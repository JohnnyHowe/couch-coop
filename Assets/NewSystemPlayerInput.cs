using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class NewSystemPlayerInput : APlayerInputController
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        // playerControls.Enable();
    }

    private void OnDisable()
    {
        // playerControls.Disable();
    }

    public override Vector2 GetMovement()
    {
        return playerInput.actions["Move"].ReadValue<Vector2>();
    }
}
