using System;

public class GameObserver {

    public static event Action onGameOver;
    public static event Action onGamePaused;
    public static event Action onGameRestart;
    

    public static void OnGameOver() {
        if (onGameOver != null) {
            onGameOver();
        }
    }

    public static void OnGamePaused() {
        if (onGamePaused != null) {
            onGamePaused();
        }
    }

    public static void OnGameRestart() {
        if (onGameRestart != null) {
            onGameRestart();
        }
    }
}
