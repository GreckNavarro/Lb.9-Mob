using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventsSystem : MonoBehaviour
{
    public static Action StartGame;
    public static Action StopGame;
    public static Action IsPlaying;
    public static Action onDead;
    public static Action<int> onDamaged;
    public static Action<int> onHealing;
    public static Action onEndGame;

    public static Action LevelStart;
    public static Action LevelComplete;

    public static Action onStartScene;
    public static Action onEndScene;


    public static Action<EffectsSO> EventSpecial;

}
