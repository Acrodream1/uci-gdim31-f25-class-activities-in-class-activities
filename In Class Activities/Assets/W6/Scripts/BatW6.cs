using NUnit.Framework;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private int speed;

    private bool _chase = false;

    private float delta;

    private Vector3 _targetPosition;
    private Vector3 _direction;

    private void Update()
    {
        if (_chase)
        {
            _direction = (_targetPosition - transform.position).normalized;
            transform.Translate(_direction * speed * Time.deltaTime);
        }
    }
    public void ChasePlayer(Vector3 playerPosition)
    {
        _chase = true;

        _targetPosition = playerPosition;
    }

    public void StopChase()
    {
        _chase = false;

        _targetPosition = Vector3.zero;
    }
}
