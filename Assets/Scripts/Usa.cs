using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usa : MonoBehaviour
{

    public Animator doorAnim;

    [SerializeField] private AudioSource doorOpenAudioSource = null;
    [SerializeField] private float openDelay = 0;

    [SerializeField] private AudioSource doorCloseAudioSource = null;
    [SerializeField] private float closeDelay = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Box"))
        {
            doorAnim.SetTrigger("open");
            Debug.Log("deshis");
            doorOpenAudioSource.PlayDelayed(openDelay);

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Box"))
        {
            doorAnim.SetTrigger("close");

            doorOpenAudioSource.PlayDelayed(closeDelay);
        }
    }
}
