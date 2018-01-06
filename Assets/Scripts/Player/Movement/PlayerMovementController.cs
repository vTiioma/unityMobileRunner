using UnityEngine;

public class PlayerMovementController : PlayerMovementApp {
    protected virtual void Start() {
        GameObserver.onGameOver += OnGameOver;
    }

    private void OnGameOver() {
        model.UpdateSpeed(0.0f);
    }
}
