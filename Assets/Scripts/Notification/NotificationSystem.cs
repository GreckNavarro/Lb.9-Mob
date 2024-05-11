using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_ANDROID
using Unity.Notifications.Android;
using UnityEngine.Android;
#endif

public class NotificationSystem : MonoBehaviour
{
    private const string idCanal = "canalNotificacion";
    private NotificationSO NotificationSO;
    private ChannelNotificationSO[] ChannelsSO;
    

    private void Start()
    {
#if UNITY_ANDROID
        RequestAuhtorization();
        RegisterDefaultNotificationChannel();
#endif
    }

#if UNITY_ANDROID
    //Request authorization to send notifications
    public void RequestAuhtorization()
    {
        if (!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS"))
        {
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }
    }

    //Register a Notification Channel
    public void RegisterDefaultNotificationChannel()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel
        {
            Id = "default_channel",
            Name = "Default",
            Importance = Importance.Default,
            Description = "Notifications"
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    //Register a New Notification Channel
    public void RegisterNotificationChannel(ChannelNotificationSO newchannel)
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel
        {
            Id = newchannel.Id,
            Name = newchannel.Name,
            Importance = newchannel.Importance,
            Description = newchannel.Description
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }


    // Send Notification in default channel
    public static void SendNotificationDefaultChannel(NotificationSO so)
    {
        AndroidNotification notification = new AndroidNotification();
        notification.Title = so.title;
        notification.Text = so.text;
        notification.FireTime = DateTime.Now;
        notification.SmallIcon = so.idSmallIcon;
        notification.LargeIcon = so.idLargeIcon;

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }

    // Send Notification in specific channel
    public static void SendNotificationSpecificChannel(NotificationSO so)
    {
        AndroidNotification notification = new AndroidNotification();
        notification.Title = so.title;
        notification.Text = so.text;
        notification.FireTime = DateTime.Now;
        notification.SmallIcon = so.idSmallIcon;
        notification.LargeIcon = so.idLargeIcon;


        AndroidNotificationCenter.SendNotification(notification, so.channel.name);
    }



#endif
}
