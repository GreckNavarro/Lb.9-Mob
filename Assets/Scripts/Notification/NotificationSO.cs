using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NotificationSO", menuName = "ScriptableObjects/Notification", order = 1)]

public class NotificationSO : ScriptableObject
{
    public string title;
    public string text;

    public string idSmallIcon;
    public string idLargeIcon;

    public ChannelNotificationSO channel;

    public void ChangeCurrentScore(int score)
    {
        text = score.ToString();
    }
}
