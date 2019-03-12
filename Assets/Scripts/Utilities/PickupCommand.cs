using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCommand : Command
{
    Pickup pickupScript;

    public PickupCommand(GameObject MovingObject)
    {
        pickupScript  = MovingObject.GetComponent<Pickup>();
        if (pickupScript == null)
        {
            Debug.LogError("Object Should Contains Pickup Script");
        }
    }
    //Called when we press a key
    public override void Execute()
    {
        StartPickObject();
    }
    public override void StopExecuting()
    {
    }
    //Undo an old command
    public override void Undo()
    {
    }

    //Move the Object
    public void StartPickObject()
    {
        pickupScript.PickObject();

    }
}
