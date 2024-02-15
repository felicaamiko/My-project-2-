using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetupState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public GameSetupState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Main Menu");
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("move to gameplay arena goober");
        Debug.Log("_______________________________");
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void Update()
    {
        base.Update();
        // wait 2 seconds before moving to Tapping state
        // StateDuration returns how long we've been in a state
        //StateDuration >= 2 was prev condition
        if (Input.GetKeyDown("space"))
        {
            _stateMachine.ChangeState(_stateMachine.TappingState);
        }
    }
}
