using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GunController theGun;
    public FixedJoystick lookJoystick;
    public FixedJoystick moveJoystick;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hoz = lookJoystick.Horizontal;
        float ver = lookJoystick.Vertical;
        float h = moveJoystick.Horizontal;
        float v = moveJoystick.Vertical;

        if(hoz!=0||ver!=0)
        {
            theGun.isFiring=true;
            anim.SetInteger("Condition",1);
            Debug.Log("Condition is 1");
           // Debug.Log("Hoz not zero");
        }
        if(hoz==0)
        {
            theGun.isFiring=false;
            anim.SetInteger("Condition",0);
            //Debug.Log("Hoz is zero");
        }
        if(h!=0||v!=0)
        {
            //theGun.isFiring=false;
            anim.SetInteger("Condition",2);
        }
        if((h==0||v==0)&&(hoz==0||ver==0))
        {
            //theGun.isFiring=false;
            anim.SetInteger("Condition",0);
        }
        // if(ver<0)
        // {
        //     //theGun.isFiring=false;
        //     Debug.Log("Ver is less than zero");
        // }
        // if(hoz>0)
        // {
        //     //theGun.isFiring=false;
        //     Debug.Log("Hoz is more than zero");
        // }
        // if(hoz<0)
        // {
        //     //theGun.isFiring=false;
        //     Debug.Log("Hoz is less than zero");
        // }
    }
}
