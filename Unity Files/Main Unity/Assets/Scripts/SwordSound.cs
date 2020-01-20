using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSound : MonoBehaviour
{
    AudioSource audioData;
    public void PlaySound()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play();
    }
}
