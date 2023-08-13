using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Animator elevator;

    [SerializeField] private AudioSource doorOpenAudioSource = null;
    [SerializeField] private float openDelay = 0;

    [SerializeField] private AudioSource doorCloseAudioSource = null;
    [SerializeField] private float closeDelay = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            elevator.SetTrigger("UP");
        }
        doorOpenAudioSource.PlayDelayed(openDelay);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            elevator.SetTrigger("Down");
        }
        doorOpenAudioSource.PlayDelayed(closeDelay);
    }
}
