using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    PlayerSP playerBlue;
    [SerializeField]
    PlayerSP playerRed;
    [SerializeField]
    GameObject playerBlueGameObject;
    [SerializeField]
    GameObject playerRedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        playerBlue.PlayerObject = playerBlueGameObject;
        playerRed.PlayerObject = playerRedGameObject;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
