using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AK.Wwise.Event soundEffect;
    public AK.Wwise.Event musicEvent;
    public AK.Wwise.Event ambienceEvent;


    public void PlayMusic()
    {
        musicEvent.Post(gameObject);
    }

    public void playSoundEffect()
    {
        soundEffect.Post(gameObject);
    }

    public void PlayAmbience()
    {
        ambienceEvent.Post(gameObject);
    }
}
