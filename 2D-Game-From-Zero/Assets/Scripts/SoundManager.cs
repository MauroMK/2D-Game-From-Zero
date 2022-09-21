using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip skeletonDeath;

    private List<AudioSource> audios;

    private void Awake()
    {
        audios = new List<AudioSource>();
        if (skeletonDeath != null)
        {
            var audioS = gameObject.AddComponent<AudioSource>();
            audioS.clip = skeletonDeath;
            audioS.name = "SkeletonDeath";
            audios.Add(audioS);
        }
    }

    public void PlayAudio(string name)
    {
        foreach (var audio in audios)
        {
            if (audio.name == name)
            {
                audio.Play();
                break;
            }
        }
    }
}
