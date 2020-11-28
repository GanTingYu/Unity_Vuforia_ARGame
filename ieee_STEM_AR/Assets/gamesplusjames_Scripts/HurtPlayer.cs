using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;
    public float delayTime=0;
    private float SavedTime=0;
    

    public void OnTriggerStay(Collider other)
    {
        if( (Time.time - SavedTime) > delayTime ) {
            SavedTime=Time.time;
            if(other.gameObject.tag=="Player")
            {
                Debug.Log("Touched Player");
                other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            }   
          }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
