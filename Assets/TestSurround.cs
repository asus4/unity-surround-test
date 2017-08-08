using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TestSurround : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSpeakerMode speakerMode;

    AudioSource audioSource;

    private void Start()
    {
        AudioSettings.speakerMode = speakerMode;
        audioSource = GetComponent<AudioSource>();
    }

    public void OnChannelSelect(int index)
    {
        Debug.LogFormat("On index select : {0}", index);
        if (index == 0)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.clip = clips[index - 1];
            audioSource.Play();
        }
    }

}
