using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public float globalvolumefactor = 1;
    public AudioSource asteroidsource;
    public AudioClip asteroidsound;
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
    public void SetGlobalVolume(float factor)
    {
        globalvolumefactor = factor;
    }
    public void SetVolume(string name, float volume)
    {
        
        //Debug.Log("vol");
        Sound s = Array.Find(sounds, sound => sound.names == name);
      
            s.targetvolume = volume*globalvolumefactor;
        
       
        /*while (Mathf.Abs(s.source.volume-volume) < 0.01)
        {
            s.source.volume = Mathf.SmoothDamp(s.source.volume, volume, ref velocity, 0.7f * Time.deltaTime);
            yield return null;
        }
        yield return null;*/
        
       
    }
    public void SetMaxVolume(string name)
    {

       // Debug.Log("maxingvaolumr");
        Sound s = Array.Find(sounds, sound => sound.names == name);
       // Debug.Log(s.names);
        s.targetvolume = s.defaultvolume*globalvolumefactor;


        /*while (Mathf.Abs(s.source.volume-volume) < 0.01)
        {
            s.source.volume = Mathf.SmoothDamp(s.source.volume, volume, ref velocity, 0.7f * Time.deltaTime);
            yield return null;
        }
        yield return null;*/


    }
        public IEnumerator jiggleVolume(Sound s)
    {
        float velocity = 0;
        while (true)
        {
          //  Debug.Log(velocity);
            //  Debug.Log("does thiswork");
            s.volume = Mathf.Lerp(s.volume, s.targetvolume, s.faderange);//Mathf.SmoothDamp(s.volume, s.targetvolume, ref velocity, 0.2f * Time.deltaTime);
            s.source.volume = s.volume;
            yield return null;
        }
        yield return null;
    }
    public void InstancePlay(string name)
    {

        /* Sound s = Array.Find(sounds, sound => sound.names == name);
         // s.source.volume = s.defaultvolume;
         //s.volume = s.defaultvolume;
         GameObject parent = s.parent;
         s.source = parent.AddComponent<AudioSource>();

         s.source.clip = s.clip;
         s.source.volume = s.volume;
         s.source.loop = s.loops;

             s.source.Play();


         StartCoroutine(jiggleVolume(s));
         StartCoroutine(endDestroyer(s));*/
      //  Sound s = Array.Find(sounds, sound => sound.names == name);
       asteroidsource.PlayOneShot(asteroidsound);
    }
    public void Play(string name)
    {
        
        Sound s = Array.Find(sounds, sound => sound.names == name);
       // s.source.volume = s.defaultvolume;
        //s.volume = s.defaultvolume;
        if (!s.source.isPlaying)
        {
            s.source.Play();
        }
      
        StartCoroutine(jiggleVolume(s));
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
        s.source.Stop();
    }
    public IEnumerator FadeIn(string name, float speed)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
         //s.source.Play();
       // float speed = 0.0005f;
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
    public IEnumerator FadeOut(string name, float speed, float endvolume)
    {
        Sound s = Array.Find(sounds, sound => sound.names == name);
       // float speed = 0.0025f;
        while (s.volume > endvolume)
        {
            s.volume -= speed;
            s.source.volume = s.volume;
            yield return new WaitForSeconds(0.1f);
        }
        while (s.volume < endvolume)
        {
            
            s.volume = 0;
            s.source.volume = s.volume;
           // s.source.Stop();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
