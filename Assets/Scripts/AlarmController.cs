using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(BoxCollider2D))] 

public class AlarmController : MonoBehaviour
{
    [SerializeField] private float _volumeUpSpeed;

    private AudioSource _audioSource;

    private bool _isInArea = false;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _isInArea = true;
            _audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
            _isInArea = false;
    }


    private void FixedUpdate()
    {
        ControlAlarmSound();
    }

    private void ControlAlarmSound()
    {
        if (_isInArea)
            _audioSource.volume += Time.deltaTime * _volumeUpSpeed;
        else
            _audioSource.volume -= Time.deltaTime * _volumeUpSpeed;   
    }
}
