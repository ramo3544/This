using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    public GameState GameState;
    void Awake()
    {
        GameManagerInstance = this;
    }

    private void Start()
    {
        ChangeGameState(GameState.GenerateGrid);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGameState(GameState newState)
    {
        GameState = newState;
        switch(newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnPlayer:
                break;
            case GameState.SpawnHazards:
                break;
            case GameState.PlayersTurn:
                break;
            case GameState.EnemiesTurn:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}
public enum GameState
{
    GenerateGrid = 0,
    SpawnPlayer = 1,
    SpawnHazards = 2,
    PlayersTurn = 3,
    EnemiesTurn = 4
}
