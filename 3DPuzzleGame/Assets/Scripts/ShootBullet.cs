using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    GameObject bulletShooter;
    bool alreadyShoot = false;

    void Awake()
    {
        bulletShooter = GameObject.FindGameObjectWithTag("Bullet");
        bulletShooter.SetActive(false);
    }

    public void Shoot()
    {
        if (alreadyShoot == false)
        {
            bulletShooter.SetActive(true);
            alreadyShoot = true;
        }
    }

}
