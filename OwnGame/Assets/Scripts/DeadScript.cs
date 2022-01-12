using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{
    public AudioClip dead;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        dead = Resources.Load<AudioClip>("dead");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(dead);
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
