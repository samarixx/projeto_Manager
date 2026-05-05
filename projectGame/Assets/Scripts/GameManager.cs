using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    void Awake()
    {
        Instance = this;
    }
    
    
    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Menu:
                break;
            case GameState.Credits:
                break;
            case GameState.GameOver:
                break;
        }
}

public enum GameState
{
    Menu,
    Game,
    GameOver,
    Credits
}