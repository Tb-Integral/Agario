using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    private MeshRenderer _mesh;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            _mesh.material.color = Color.red;

        if (Input.GetKeyDown(KeyCode.G))
            _mesh.material.color = Color.green;

        if (Input.GetKeyDown(KeyCode.B))
            _mesh.material.color = Color.blue;
    }
}
