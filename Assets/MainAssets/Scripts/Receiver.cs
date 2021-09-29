using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : ActionController
{
    [SerializeField] private GameObject example;
    [SerializeField] private ScoreController scoreController;
    protected override void PressFAction(Collider other)
    {
        BaggageController baggageController = other.gameObject.GetComponent<BaggageController>();
        var baggage = baggageController.GetBaggage();
        if (TryReceive(baggage))
        {
            baggageController.Clear();
        }
    }
    public bool TryReceive(GameObject baggage)
    {
        if (baggage)
        {
            if (baggage.tag == example.tag)
            {
                scoreController.AddCount(baggage.tag);
                return true;
            }
        }

        return false;
    }
}
