using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NotificationSO", menuName = "ScriptableObjects/Channel", order = 2)]

public class ChannelNotificationSO : ScriptableObject
{
    public string Id;
    public string Name;
    public Unity.Notifications.Android.Importance Importance;
    public string Description;

}

