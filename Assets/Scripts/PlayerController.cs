using System;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(SpriteRenderer))]

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    
    private float _speed = 1f;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * _speed;
        
        _spriteRenderer.flipX = movement < 0 ? true : false;
        _animator.SetFloat("Speed",  Math.Abs(movement));
    }
}
