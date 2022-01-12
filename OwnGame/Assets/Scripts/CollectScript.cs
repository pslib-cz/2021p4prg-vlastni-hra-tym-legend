using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    public AudioClip collect;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        collect = Resources.Load<AudioClip>("collect");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(collect);
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
