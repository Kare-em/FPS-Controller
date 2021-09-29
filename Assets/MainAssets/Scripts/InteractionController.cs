using UnityEngine;

public class InteractionController : ActionController
{
    protected override void PressFAction(Collider other)
    {
        BaggageController baggageController = other.gameObject.GetComponent<BaggageController>();
        var baggage = baggageController.GetBaggage();
        if (baggage == null)
        {
            baggageController.TakeBaggage(gameObject);
            Destroy(this);
        }
    }

}
    
