using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfUrns { get; private set; }

    public UnityEvent<PlayerInventory> OnUrnCollected;

    public void UrnCollected()
    {
        NumberOfUrns++;
        OnUrnCollected.Invoke(this);
    }
}
