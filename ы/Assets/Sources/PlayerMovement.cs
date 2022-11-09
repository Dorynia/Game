using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] 
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private Joystick _joystick;

    [SerializeField] private float _speed;

    private float _horizontal;
    private float _vertical;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontal = _joystick.Horizontal;
        _vertical = _joystick.Vertical;
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_horizontal * _speed, _vertical * _speed);
    }
}
