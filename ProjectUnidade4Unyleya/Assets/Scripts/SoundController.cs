using UnityEngine;
using System.Collections.Generic;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    public List<AudioClip>soundList;

    [SerializeField]
    private AudioSource audioSource;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
