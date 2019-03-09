using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovingDirction { 
    Up,Down,Left,Right
}
public class MovingCommand : Command
{
    private MovingDirction _movingDirction;
    private FloatRefrence _moveSpeed;
    private Rigidbody2D _movmentHandler;

    public MovingCommand(GameObject MovingObject, FloatRefrence moveSpeed, MovingDirction movingDirction)
    {
        _movingDirction = movingDirction;
        _moveSpeed = moveSpeed;
        _movmentHandler = MovingObject.GetComponent<Rigidbody2D>();
        if (_movmentHandler == null)
        {
            Debug.LogError("Moving Object Should Contains Rigidbody");
        }
    }
    //Called when we press a key
    public override void Execute()
    {
        //Move the box
        Move();
    }
    public override void StopExecuting()
    {
        _movmentHandler.velocity = new Vector2(_movmentHandler.velocity.x, 0);
    }
    //Undo an old command
    public override void Undo()
    {
        _movmentHandler.velocity = new Vector2(_movmentHandler.velocity.x, -_moveSpeed.Value);
    }

    //Move the Object
    public void Move()
    {
        switch (_movingDirction)
        {
            case MovingDirction.Up:
                _movmentHandler.velocity = new Vector2(_movmentHandler.velocity.x, _moveSpeed.Value);
                break;
            case MovingDirction.Down:
                _movmentHandler.velocity = new Vector2(_movmentHandler.velocity.x, -_moveSpeed.Value);
                break;
            case MovingDirction.Left:
                _movmentHandler.velocity = new Vector2( -_moveSpeed.Value, _movmentHandler.velocity.y);
                break;
            case MovingDirction.Right:
                _movmentHandler.velocity = new Vector2( _moveSpeed.Value,_movmentHandler.velocity.y);
                break;

            default:
                break;
        }

    }
}
