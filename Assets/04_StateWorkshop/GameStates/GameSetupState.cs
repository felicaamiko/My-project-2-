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

        Debug.Log("|Welcome to Duck, Duck, Goose|");
        Debug.Log("Goal: Catch the goose!");
        Debug.Log("Q taps a head : Space catches the goose");
        Debug.Log("You have limited time to catch the goose, so be quick!");
        Debug.Log("Don't accidentally catch a duck, or the goose will go free");
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("Let the goosing begin!");
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
        if(StateDuration >= 2)
        {
            _stateMachine.ChangeState(_stateMachine.TappingState);
        }
    }
}
