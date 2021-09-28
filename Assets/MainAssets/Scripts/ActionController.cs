using UnityEngine;

public class ActionController : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                BaggageController baggageController = other.gameObject.GetComponent<BaggageController>();
                var baggage = baggageController.GetBaggage();
                if (baggage == null)
                {
                    Debug.Log(baggage);
                    baggageController.TakeBaggage(gameObject);
                    Destroy(this);
                }
            }

        }
    }
}
