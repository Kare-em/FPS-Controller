using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaggageController : MonoBehaviour
{
    [SerializeField] private Transform slot;
    private GameObject baggage;
    public GameObject GetBaggage()
    {
        return baggage;
    }

    internal void Clear()
    {
        Destroy(baggage);
    }

    internal void TakeBaggage(GameObject newBaggage)
    {
        baggage = newBaggage;
        baggage.transform.parent = slot;
        baggage.transform.position = slot.position;
    }
}
