using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Vector3 _movementDirection;
    private void Start()
    {
        Debug.Log("HELLLLOOOO");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(_movementDirection, Space.World);
    }
}
