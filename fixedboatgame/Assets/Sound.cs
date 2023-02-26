using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string names;

    public AudioClip clip;

    public bool loops;

    [Range(0f,1f)]
    public float defaultvolume;

    [Range(0f, 1f)]
    public float volume;

    [Range(0f, 1f)]
    public float targetvolume;

    [Range(0.1f,3f)]
    public float pitch;

    [Range(0f, 1f)]
    public float faderange;

    [HideInInspector]
    public AudioSource source;

    public GameObject parent;
}
