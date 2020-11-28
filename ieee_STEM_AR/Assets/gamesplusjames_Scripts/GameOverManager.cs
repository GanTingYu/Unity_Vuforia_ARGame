using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealthManager PcurrentHealth;
    public float restartDelay=5f;

    Animator anim;
    float restartTimer;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PcurrentHealth.currentHealth<=0)
        {
            anim.SetTrigger("GameOver");
            restartTimer+=Time.deltaTime;
            if(restartTimer>=restartDelay)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
