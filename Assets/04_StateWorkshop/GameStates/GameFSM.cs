using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the state machine works with the controller to receive data
[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    // state instances
    public GameSetupState SetupState { get; private set; }
    public GameTappingState TappingState { get; private set; }
    public GameGooseState GooseState { get; private set; }

    private GameController _gameController;

    private void Awake()
    {
        // grab local components
        _gameController = GetComponent<GameController>();
        // create states
        SetupState = new GameSetupState(this, _gameController);
        TappingState = new GameTappingState(this, _gameController);
        GooseState = new GameGooseState(this, _gameController);
    }

    private void Start()
    {
        ChangeState(SetupState);
    }
}
