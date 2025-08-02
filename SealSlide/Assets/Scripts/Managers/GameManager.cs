using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalFishCollected { get; private set; }

    public static GameManager Instance;

    private void Awake()
    {
        //Creating Singleton of the game manager
        if (Instance == null)
        { 
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
            

    }

    public void IncreaseFishCollected()
    {
        totalFishCollected++;
    }

}
