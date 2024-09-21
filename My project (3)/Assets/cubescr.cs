using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescr : MonoBehaviour
{

    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        var direction = (_player.position - transform.position).normalized;
        transform.Translate(direction * _speed);
    }
}
