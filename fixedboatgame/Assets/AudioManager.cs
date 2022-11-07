using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            GameObject parent = s.parent;
            s.source = parent.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            
        }
    }

    // Update is called once per frame
    public void SetVolume(float volume)
    {
        //Debug.Log(volume);
        Sound s = Array.Find(sounds, sound => sound.names == "music");
        s.source.volume = volume;
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
        s.source.Play();
    }
}
