using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Collectible : MonoBehaviour
{
    public int NumberofPebbles{get;private set;}
    public UnityEvent<Collectible> OnPebbleCollected;
    public void PebbleCollected()
    {
        NumberofPebbles++;
        OnPebbleCollected.Invoke(this);
    }
}
