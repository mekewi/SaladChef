using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    PlayerSP playerSP;

    public TextMeshPro pickedItemsName;
    // Start is called before the first frame update
    void Start()
    {
        playerSP.PickedItems.Clear();
    }
    public void PickedItem(Item PickedItem) {
        if (playerSP.PickedItems.Count < playerSP.MaxPickedItem && !playerSP.PickedItems.Contains(PickedItem))
        {
            playerSP.PickedItems.Add(PickedItem);
            pickedItemsName.text += PickedItem.ItemName + ",";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
