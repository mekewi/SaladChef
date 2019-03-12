using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VegetableItem : Item
{

    public LayerMask layerMask;
    [SerializeField]
    GameManagerSO gameManagerData;
    [SerializeField]
    MovingDirction rayCastDirction;
    public TextMeshPro ItemNameText;

    // Start is called before the first frame update
    void Start()
    {
        ItemNameText.text = ItemName;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        Vector2 fwd = transform.TransformDirection(GetDirction());
        Debug.DrawRay(transform.position, fwd * gameManagerData.DistanceToPickup.Value, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, fwd, gameManagerData.DistanceToPickup.Value, layerMask);
        if (hit)
        {
            Pickup pickup = hit.collider.GetComponent<Pickup>();
            if (pickup)
            {
                pickup.CurrentHoverObject = gameObject;
            }
        }
    }

    private Vector2 GetDirction() {
        switch (rayCastDirction)
        {
            case MovingDirction.Up:
                return Vector2.up;
            case MovingDirction.Down:
                return Vector2.down;
            case MovingDirction.Left:
                return Vector2.left;
            case MovingDirction.Right:
                return Vector2.right;
            default:
                return Vector2.left;
        }

    }
}
