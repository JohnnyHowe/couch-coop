using UnityEngine;

[RequireComponent(typeof(APlayerInputController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;
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
        Debug.Log(movement);
        rigidbody.velocity = new Vector3(movement.x, 0, movement.y) * speed;
    }
}
