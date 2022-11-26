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
            s.source.loop = s.loops;
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
       // s.source.volume = s.defaultvolume;
        //s.volume = s.defaultvolume;
        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
        s.source.Stop();
    }
    public IEnumerator FadeIn(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
         //s.source.Play();
        float speed = 0.0005f;
        while (s.volume < s.defaultvolume)
        {
            s.volume += speed;
            s.source.volume = s.volume;
            yield return new WaitForSeconds(0.1f);
        }
        while (s.volume > s.defaultvolume)
        {
            s.volume = s.defaultvolume;
            s.source.volume = s.defaultvolume;
            yield return new WaitForSeconds(0.1f);
        }
       
    }
    public IEnumerator FadeOut(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
        float speed = 0.0025f;
        while (s.volume > 0)
        {
            s.volume -= speed;
            s.source.volume = s.volume;
            yield return new WaitForSeconds(0.1f);
        }
        while (s.volume < 0)
        {
            
            s.volume = 0;
            s.source.volume = s.volume; ;
           // s.source.Stop();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
