using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "Mussic", menuName = "ScriptableObjects/Music", order = 3)]

public class MusicSO : ScriptableObject
{
    public AudioClip myAudio;
    public AudioMixerGroup myGroup;


}

