using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FishCollectedUI : MonoBehaviour
{
    private TextMeshProUGUI fishCollectedText;
    [SerializeField] private SO_EventSender _eventSender;

    private void Awake()
    {
        fishCollectedText = GetComponent<TextMeshProUGUI>();
        _eventSender.FishCollectedEvent.AddListener(IncreaseText);
    }

    public void IncreaseText()
    {
        GameManager.Instance.IncreaseFishCollected();
        fishCollectedText.text = GameManager.Instance.totalFishCollected.ToString();
       
    }
}
