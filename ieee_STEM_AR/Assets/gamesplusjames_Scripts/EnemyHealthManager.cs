using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    public float health;
    private float currentHealth;

    public GameObject healthBarUI;
    public Slider slider;

    public int scoreValue =10;

    //AudioSource enemy_DeathSound;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=health;
        slider.value=CalculateHealth();
        //enemy_DeathSound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value=CalculateHealth();
        if(currentHealth<=0)
        {
           // enemy_DeathSound.Play();
           scoreManager.score+=scoreValue;
            Destroy(gameObject);
            
        }
    }

    public void HurtEnemy(int damage){
        currentHealth-=damage;
    }

    float CalculateHealth()
    {
        return currentHealth/health;
    }
}
