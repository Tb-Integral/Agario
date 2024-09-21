using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFall : MonoBehaviour
{

    [SerializeField] private GameObject[] balls;
    private int oaa;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(balls[Random.Range(0, balls.Length)], new Vector3(Random.Range(330f, 350f), Random.Range(-5, 20), Random.Range(180f, 200f)), Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
