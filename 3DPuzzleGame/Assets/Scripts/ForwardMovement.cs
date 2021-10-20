using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] int forwardSpeed;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Movement(transform);
    }

    void Movement(Transform objectTransform)
    {
        rigidBody.velocity = objectTransform.forward * forwardSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DirectionChanger"))
        {
            Movement(other.gameObject.transform);
        }
    }

}
