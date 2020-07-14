using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//添加劇本時會自動給予該物件AudioSource
[RequireComponent(typeof(AudioSource))]
public class HorrorSound : HorrorObject
{
    private AudioSource aud;

    public AudioClip sound;

    public float volume = 1;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    public override void TriggerEvent()
    {
        aud.PlayOneShot(sound, volume);

    }




}
