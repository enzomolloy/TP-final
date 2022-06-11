using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sonido1;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;

    public void PlayClip1()
    {
        sonido1.clip = clip1;
        sonido1.Play();
    }
    public void PlayClip2()
    {
        sonido1.clip = clip2;
        sonido1.Play();
    }
    public void PlayClip3()
    {
        sonido1.clip = clip3;
        sonido1.Play();
    }
    public void PlayClip4()
    {
        sonido1.clip = clip4;
        sonido1.Play();
    }
    public void PlayClip5()
    {
        sonido1.clip = clip5;
        sonido1.Play();
    }
    public void PlayClip6()
    {
        sonido1.clip = clip6;
        sonido1.Play();
    }
}
