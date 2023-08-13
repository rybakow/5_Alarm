using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]

public class DoorController : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _animator.SetBool("IsOpen", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _animator.SetBool("IsOpen", false);
        }
    }
}
