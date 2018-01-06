using System;

public class PlayerMovementModel {
    public event Action<float> onUpdateSpeed;

    protected float speed = 0.0f;

    public static implicit operator bool(PlayerMovementModel reference) {
        return reference != null;
    }

    public virtual void UpdateSpeed(float amount) {
        if (this.onUpdateSpeed != null) {
            this.onUpdateSpeed(amount);
        }
    }
}
