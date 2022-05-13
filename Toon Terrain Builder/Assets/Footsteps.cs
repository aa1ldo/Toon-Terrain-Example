using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField] private AudioClip[] footsteps;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip land;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Step()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    public void Jump()
    {
        audioSource.PlayOneShot(jump);
    }

    public void Land()
    {
        audioSource.PlayOneShot(land);
    }

    /*
    public void Float()
    {
        audioSource.Play();
    }
    */

    private AudioClip GetRandomClip()
    {
        return footsteps[UnityEngine.Random.Range(0, footsteps.Length)];
    }
}
