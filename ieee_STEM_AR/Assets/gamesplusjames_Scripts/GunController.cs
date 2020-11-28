﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounter;
    public Transform firePoint;
    AudioSource m_shootingSound;

    // Start is called before the first frame update
    void Start()
    {
        m_shootingSound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isFiring)
        {
            shotCounter-=Time.deltaTime;
            if(shotCounter<=0)
            {
                m_shootingSound.Play();
                shotCounter=timeBetweenShots;
                BulletController newBullet=Instantiate(bullet,firePoint.position,firePoint.rotation)as BulletController;
                newBullet.speed=bulletSpeed;
            }

        }
        else
        {
            shotCounter=0;
        }
    }
}
