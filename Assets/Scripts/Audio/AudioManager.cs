using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource audiosource;
    
    public void PlayAudioMusic(MusicSO music)
    {
        audiosource.outputAudioMixerGroup = music.myGroup;
        audiosource.PlayOneShot(music.myAudio);
    }
    
    public void PlayEffect(EffectsSO effect)
    {
        effect.StartSoundSelection();
    }

    public void PauseAudio()
    {
        if (audiosource != null)
        {
            if (audiosource.isPlaying)
            {
                audiosource.Pause();
            }
            else
            {
                audiosource.UnPause();
            }
        }
    }

}
