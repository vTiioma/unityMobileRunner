using System;

public class PlayerJumpModel {
    public event Action<float> onJump;
    public event Action<float> onGlide;

    public static implicit operator bool(PlayerJumpModel reference) {
        return reference != null;
    }

    public virtual void Jump(float force) {
        if (onJump != null) {
            onJump(force);
        }
    }

    public virtual void Glide(float force) {
        if (onGlide != null) {
            onGlide(force);
        }
    }
}
