using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public GameObject CurrentHoverObject;
    public GameManagerSO gameManagerData;
    [SerializeField]
    public PickupEvent PickUpAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PickObject() {
        if (CurrentHoverObject)
        {
            Item itemToPick = CurrentHoverObject.GetComponent<Item>();
            if (itemToPick != null)
            {
               PickUpAction.Invoke(itemToPick);
            }
            else
            {
                Debug.Log("Item To Pick should have Item Script");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (CurrentHoverObject)
        {
            bool isStillHover = Vector2.Distance(transform.position, CurrentHoverObject.transform.position) < gameManagerData.DistanceToPickup.Value*2;
            if (!isStillHover)
            {
                CurrentHoverObject = null;
            }
        }
    }
}
