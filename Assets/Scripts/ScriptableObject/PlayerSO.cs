using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerSP : ScriptableObject
{
    public GameObject PlayerObject;
    public FloatRefrence Speed;
    public int MaxPickedItem;
    public List<Item> PickedItems = new List<Item>();

}
