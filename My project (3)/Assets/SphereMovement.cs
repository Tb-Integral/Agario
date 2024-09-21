using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float InputX, InputZ;
    [SerializeField] public float _speed = 5.0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        InputX = Input.GetAxis("Vertical");
        InputZ = -Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(InputX, 0, InputZ) * _speed;
        

    }
}
