using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;

    public void Button()
    {
        src.clip = sfx;
        src.Play();
    }
}
