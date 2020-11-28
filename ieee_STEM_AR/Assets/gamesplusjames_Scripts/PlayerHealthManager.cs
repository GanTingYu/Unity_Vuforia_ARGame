using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;

    AudioSource playerDeathSound;

    public GameObject healthBarUI;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=startingHealth;
        playerDeathSound=GetComponent<AudioSource>();
        slider.value=CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value=CalculateHealth();
        if(currentHealth<=0)
        {
            playerDeathSound.Play();
            gameObject.SetActive(false);
        }
    }

    public void HurtPlayer(int damageAmount)
    {
        currentHealth-=damageAmount;
    }

    float CalculateHealth()
    {
        return currentHealth/startingHealth;
    }
}
