using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGooseState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;
    // this is how long we have to catch the goose before it escapes
    private float _gooseTimeLimit;

    public GameGooseState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;

        _gooseTimeLimit = controller.GooseTimeLimit;
    }

    public override void Update()
    {
        base.Update();

        if (StateDuration >= _gooseTimeLimit) {
            Debug.Log("Goose got away. Ran out of time");
            _stateMachine.ChangeState(_stateMachine.SetupState);
        }

        // if we ever press Spacebar during Goose state, we caught the goose
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TODO Change to Win State instead
            Debug.Log("You caught a Goose, You win");
            _stateMachine.ChangeState(_stateMachine.SetupState);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //TODO Change to Win State instead
            Debug.Log("You missed a Goose, You lose");
            _stateMachine.ChangeState(_stateMachine.SetupState);
        }
    }

    //TODO override Enter, Exit, Update
    // if player doesn't press Space within the alotted time, reset the game
    // if the player DOES press Space within the alotted time, they win!
    // if the player presses Q during chase, they lose
    // print relevant messags so the player knows what's happening

    //_stateMachine.ChangeState(_stateMachine.SetupState);
}
