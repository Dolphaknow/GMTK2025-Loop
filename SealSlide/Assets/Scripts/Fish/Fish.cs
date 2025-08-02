using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private SO_EventSender _eventSender;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Seal"))
        {
            _eventSender.FishCollectedEventSend();
            Destroy(gameObject);
        }
    }
}
