using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip deathSFX;
    public AudioClip deathNinja;
    public AudioClip jumpLeeSin;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
   
   public void DeathSound()
   {
       _audioSource.PlayOneShot(deathSFX);
   }

   public void DeathNinja()
   {
       _audioSource.PlayOneShot(deathNinja);
   }

   public void JumpSound()
   {
       _audioSource.PlayOneShot(jumpLeeSin);
   }
    
}
