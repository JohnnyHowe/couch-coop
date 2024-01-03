using UnityEngine;

public class AGrabbable : MonoBehaviour
{
    public new Collider collider
    {
        get
        {
            if (_collider == null) _collider = GetComponent<Collider>();
            return _collider;
        }
    }
    private Collider _collider;

    public new Rigidbody rigidbody
    {
        get
        {
            if (_rigidbody == null) _rigidbody = GetComponent<Rigidbody>();
            return _rigidbody;
        }
    }
    private Rigidbody _rigidbody;
}
