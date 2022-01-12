using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackScript : MonoBehaviour
{
    public AudioClip jetpack;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        jetpack = Resources.Load<AudioClip>("jetpack");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(jetpack);
        }
    }

    public void StopSound()
    {
        audioSource.Stop();
    }

    public void Pause()
    {
        audioSource.Pause();
    }
    public void UnPause()
    {
        audioSource.UnPause();
    }
}
