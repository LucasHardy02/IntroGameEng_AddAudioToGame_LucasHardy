using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerShoot;
    public AudioClip asteroidExplosion;
    public AudioClip playerDamage;
    public AudioClip playerExplosion;
    public AudioClip BgMusicGameplay;
    public AudioClip BgMusicTitleScreen;

    private AudioSource SFXaudioSource;

    private AudioSource BgMusicAudioSource;

    public void Awake()
    {
        SFXaudioSource = GetComponent<AudioSource>();
        //GameObject child = this.transform.Find("BgMusic").gameObject;
        BgMusicAudioSource = gameObject.transform.Find("BgMusic").gameObject.GetComponent<AudioSource>();


        
        //BgMusicAudioSource.GetComponent<AudioSource>().Play();       
    }



    //called in the PlayerController Script
    public void PlayerShoot()
    {

        SFXaudioSource.PlayOneShot(playerShoot, 0.5f);
    }

    //called in the PlayerController Script
    public void PlayerDamage()
    {
        SFXaudioSource.PlayOneShot(playerDamage, 0.8f);
    }

    //called in the PlayerController Script
    public void PlayerExplosion()
    {
        SFXaudioSource.PlayOneShot(playerExplosion, 0.8f);
    }

    //called in the AsteroidDestroy script
    public void AsteroidExplosion()
    {
        SFXaudioSource.PlayOneShot(asteroidExplosion, 0.6f);
    }

    
    public void BGMusicMainMenu()
    {
        BgMusicAudioSource.clip = BgMusicTitleScreen;
        BgMusicAudioSource.volume = 0.5f;
        BgMusicAudioSource.Play();
    }

    public void BGMusicGameplay()
    {
        BgMusicAudioSource.clip = BgMusicGameplay;
        BgMusicAudioSource.volume = 0.5f;
        BgMusicAudioSource.Play();

    }
}
