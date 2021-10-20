using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] Rigidbody bulletPrefab;

    public void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
