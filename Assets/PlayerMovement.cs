using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(APlayerInputController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float runForce = 1;
    private APlayerInputController inputController;
    private new Rigidbody rigidbody;

    private void Awake()
    {
        inputController = GetComponent<APlayerInputController>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector2 movement = inputController.GetMovement();
        rigidbody.AddForce(new Vector3(movement.x, 0, movement.y) * runForce);
    }
}
