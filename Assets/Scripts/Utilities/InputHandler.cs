using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField]
    PlayerSP playerBlue;
    [SerializeField]
    PlayerSP playerRed;

    Rigidbody2D playerBody;
    //Player  Movement Buttons
    private Command buttonW, buttonS, buttonA, buttonD, buttonQ;
    private Command buttonI, buttonK, buttonJ, buttonL, buttonU;

    void Start()
    {
        //Bind keys with commands
        buttonW = new MovingCommand(playerBlue.PlayerObject, playerBlue.Speed,MovingDirction.Up);
        buttonS = new MovingCommand(playerBlue.PlayerObject, playerBlue.Speed, MovingDirction.Down);
        buttonA = new MovingCommand(playerBlue.PlayerObject, playerBlue.Speed, MovingDirction.Left);
        buttonD = new MovingCommand(playerBlue.PlayerObject, playerBlue.Speed, MovingDirction.Right);
        buttonQ = new PickupCommand(playerBlue.PlayerObject);

        buttonI = new MovingCommand(playerRed.PlayerObject, playerRed.Speed, MovingDirction.Up);
        buttonK = new MovingCommand(playerRed.PlayerObject, playerRed.Speed, MovingDirction.Down);
        buttonJ = new MovingCommand(playerRed.PlayerObject, playerRed.Speed, MovingDirction.Left);
        buttonL = new MovingCommand(playerRed.PlayerObject, playerRed.Speed, MovingDirction.Right);
        buttonU = new PickupCommand(playerRed.PlayerObject);


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            buttonA.Execute();
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            buttonA.StopExecuting();
        }
        if (Input.GetKey(KeyCode.D))
        {
            buttonD.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            buttonD.StopExecuting();
        }

        if (Input.GetKey(KeyCode.S))
        {
            buttonS.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            buttonS.StopExecuting();
        }

        if (Input.GetKey(KeyCode.W))
        {
            buttonW.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            buttonW.StopExecuting();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            buttonQ.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            buttonQ.StopExecuting();
        }



        if (Input.GetKey(KeyCode.J))
        {
            buttonJ.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            buttonJ.StopExecuting();
        }

        if (Input.GetKey(KeyCode.L))
        {
            buttonL.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            buttonL.StopExecuting();
        }

        if (Input.GetKey(KeyCode.K))
        {
            buttonK.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            buttonK.StopExecuting();
        }

        if (Input.GetKey(KeyCode.I))
        {
            buttonI.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            buttonI.StopExecuting();
        }

        if (Input.GetKey(KeyCode.U))
        {
            buttonU.Execute();
        }
        else if (Input.GetKeyUp(KeyCode.U))
        {
            buttonU.StopExecuting();
        }

    }
}
