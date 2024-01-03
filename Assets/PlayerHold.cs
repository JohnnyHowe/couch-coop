using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(APlayerInputController))]
public class PlayerHold : MonoBehaviour
{
    [SerializeField] private float grabbableRange = 2;
    private APlayerInputController inputController;
    private AGrabbable itemHeld;
    private SpringJoint springJoint;
    private float springForce;

    private void Awake()
    {
        inputController = GetComponent<APlayerInputController>();
        inputController.onGrabChange.AddListener(OnGrabChange);
        springJoint = GetComponent<SpringJoint>();
        springForce = springJoint.spring;
    }

    private void Update()
    {
        if (itemHeld)
        {
        }
    }

    private void OnGrabChange(bool grabbing)
    {
        if (grabbing)
        {
            AGrabbable grabbable = GetTargetGrabbable();
            if (grabbable)
            {
                itemHeld = grabbable;
                springJoint.connectedBody = itemHeld.rigidbody;
                springJoint.spring = springForce;
            }
        }
        else
        {
            itemHeld = null;
            springJoint.connectedBody = null;
            springJoint.spring = 0;
        }
    }

    private AGrabbable GetTargetGrabbable()
    {
        List<AGrabbable> grabbables = new List<AGrabbable>(FindObjectsByType<AGrabbable>(FindObjectsSortMode.None));
        foreach (AGrabbable grabbable in grabbables)
        {
            if (Vector3.Distance(transform.position, grabbable.transform.position) < grabbableRange)
            {
                return grabbable;
            }
        }
        return null;
    }
}