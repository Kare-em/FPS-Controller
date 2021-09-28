using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    [SerializeField] private GameObject example;
    [SerializeField] private ScoreController scoreController;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                BaggageController baggageController = other.gameObject.GetComponent<BaggageController>();
                var baggage = baggageController.GetBaggage();
                if (TryReceive(baggage))
                {
                    baggageController.Clear();
                }
            }
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
