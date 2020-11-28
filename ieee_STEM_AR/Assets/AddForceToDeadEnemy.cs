using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToDeadEnemy : MonoBehaviour
{
    private Rigidbody rb;
    public float force;

    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
        transform.rotation=Random.rotation;
        force=Random.Range(800f,1600f);
        rb.AddForce(transform.up*force);
    }

}
