using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class NewSystemPlayerInput : APlayerInputController
{
    private PlayerInput playerInput;
    private bool lastHeldState = false;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        bool currentHeldState = GetHeld();
        if (currentHeldState != lastHeldState) onGrabChange.Invoke(currentHeldState);
        lastHeldState = currentHeldState;
    }

    public override Vector2 GetMovement()
    {
        return playerInput.actions["Move"].ReadValue<Vector2>();
    }

    public override bool GetHeld()
    {
        return playerInput.actions["Hold"].ReadValue<float>() > 0.5f;
    }
}
