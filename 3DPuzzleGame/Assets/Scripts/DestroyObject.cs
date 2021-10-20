using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Muros"))
        {
            Destroy(gameObject);
        }
    }

}