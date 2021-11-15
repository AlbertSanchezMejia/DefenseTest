using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    BulletMovement bulletShooter;
    [SerializeField] ObjectToMove ObjectShootButton;

    void Awake()
    {
        bulletShooter = FindObjectOfType<BulletMovement>();
        bulletShooter.enabled = false;
    }

    public void Shoot()
    {
        GameObject.FindGameObjectWithTag("ButtonShoot").SetActive(false);
        ObjectShootButton.havePressShootButton();
        bulletShooter.enabled = true;
    }

}
