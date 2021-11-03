using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }

}