using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Mover : MonoBehaviour
{
    private Vector3 inputDirection;
    private Rigidbody playerBody;

    [SerializeField] private float speed = 5;

    private int bump = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        transform.Translate(inputDirection * (speed * Time.deltaTime),Space.World);
    }
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag != "Ground")
        {
            bump++;
            Debug.Log("Oh no! You bumped " + bump + " times.");
        }
    }
}
