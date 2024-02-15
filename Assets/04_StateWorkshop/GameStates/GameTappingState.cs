using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the primary gameplay state. Player taps the screen and jumps. Might get accelerometer input. 
public class GameTappingState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public float offset;
    public bool killswitch = false; // extra duct tape
    public GameTappingState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;

        //_headCount = controller.HeadCount;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("use tilt to move around. tap (Q) to jump");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void Update()
    {
        
        base.Update();
        // tap a head with Q - jump
        if (Input.GetKeyDown(KeyCode.Q) && killswitch)
        {
            Jump();
        }

        if (StateDuration > offset + 4 && !killswitch)
        {
            Land();
        }



        // if we ever press Spacebar during tap state, we've tried to catch a duck.
        // this is not allowed! Game Over
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //TODO Change to Lose State instead
        //    Debug.Log("You caught a duck. Try again...");
        //    _stateMachine.ChangeState(_stateMachine.SetupState);
        //}
    }

    void Jump()
    {
        offset = StateDuration;
        killswitch = false;
        //Debug.Log(offset);
        Debug.Log("jumped");





        //// choose a random number out of the total number of heads
        //int gooseDecider = UnityEngine.Random.Range(1, _headCount + 1);
        //if (gooseDecider == 1)
        //{
        //    // enter Goose State
        //    Debug.Log("GOOSE");
        //    _stateMachine.ChangeState(_stateMachine.GooseState);
        //}
        //else
        //{
        //    Debug.Log("Duck. Keep tapping!");
        //    // remain in Tapping State
        //}
    }

    void Land() {
        Debug.Log("landed");
        killswitch = true;
    }
}
