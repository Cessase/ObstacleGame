using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private float cooldown = 3f;

    private Rigidbody obstacleBody;
    // Start is called before the first frame update
    void Start()
    {
        obstacleBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= cooldown)
        {
            obstacleBody.useGravity = true;
        } 
    }

    private void OnCollisionEnter(Collision other)
    {
        obstacleBody.AddExplosionForce(1000f,new Vector3(transform.position.x, other.transform.position.y, transform.position.z), 10f );
    }
}
