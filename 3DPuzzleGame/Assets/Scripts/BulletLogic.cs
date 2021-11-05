using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] int forwardSpeed;

    VictoryManager vManager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Movement(transform);

        vManager = FindObjectOfType<VictoryManager>();
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

        if (other.gameObject.CompareTag("Enemy"))
        {
            vManager.enemyAmount--;
        }

        if (other.gameObject.CompareTag("Muros"))
        {
            if (vManager.enemyAmount > 0) {
                vManager.Lose();
            }
            else {
                vManager.Win();
                gameObject.SetActive(false);
            }
        }


    }

}
