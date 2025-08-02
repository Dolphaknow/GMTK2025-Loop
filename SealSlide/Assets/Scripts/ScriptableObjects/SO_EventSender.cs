using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "EventSender", menuName = "Scriptable Objects/Event Sender")]
public class SO_EventSender : ScriptableObject
{
    public UnityEvent FishCollectedEvent;
    public void FishCollectedEventSend()
    {
        FishCollectedEvent.Invoke();
    }
}
