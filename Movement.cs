using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _ground;
    [SerializeField] private Transform _groundCheck; 
    [SerializeField] private SpriteRenderer _characterSprite;
    
    private bool _onGround;
    private float _checkRadius = 0.2f;
    private Vector3 _input;
    private bool _isMoving;
    private Rigidbody2D _rigidbody;
    private Animations _animations;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animations = GetComponent<Animations>();
    }

    private void Update()
    {
        Move();
        Jump();
        IsGrounded();
    }

    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _isMoving = _input.x != 0;

        if (_input.x != 0)
        {
            _characterSprite.flipX = !(_input.x > 0);
        }

        _animations.IsMove = _isMoving;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void IsGrounded()
    {
        _onGround = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _ground);
    }
}
