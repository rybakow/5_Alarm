using UnityEngine;

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
        if (collider.TryGetComponent(out PlayerController player))
        {
            _animator.SetBool(AnimatorDoorController.Params.IsOpen, true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out PlayerController player))
        {
            _animator.SetBool(AnimatorDoorController.Params.IsOpen, false);
        }
    }
}
