using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    GameObject bulletShooter;

    void Awake()
    {
        bulletShooter = GameObject.FindGameObjectWithTag("Bullet");
        bulletShooter.SetActive(false);
    }

    public void Shoot()
    {
        bulletShooter.SetActive(true);
        Destroy(this);
    }

}
