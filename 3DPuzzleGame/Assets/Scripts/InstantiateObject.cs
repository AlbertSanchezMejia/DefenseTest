using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] Rigidbody bulletPrefab;
    bool thereAlreadyABullet = false;
    public void Shoot()
    {
        if (thereAlreadyABullet == false)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            thereAlreadyABullet = true;
        }
    }

}
