using UnityEngine;

public class PlayerJumpView : PlayerJumpApp {
    protected Rigidbody2D body;

    protected virtual void Start() {
        body = this.gameObject.GetComponent<Rigidbody2D>();

        model.onJump += OnJump;
        model.onGlide += OnGlide;
    }

    private void OnJump(float value) {
        Vector2 force = Vector2.up * (value * 5.0f);
        Vector2 velocity = this.body.velocity;
        velocity.y = 0;

        this.body.velocity = velocity;
        this.body.AddForce(force, ForceMode2D.Impulse);
    }

    private void OnGlide(float value) {
        Vector2 force = Vector2.up * (value * 1.0f);
        this.body.AddForce(force, ForceMode2D.Force);
    }
}
