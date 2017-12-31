using UnityEngine;

public class PlayerMovementView : PlayerMovementApp {
    protected Rigidbody2D body;

	protected virtual void Start () {
        body = this.gameObject.GetComponent<Rigidbody2D>();

        model.onUpdateSpeed += OnUpdateSpeed;
	}

    protected virtual void OnUpdateSpeed(float speed) {
        this.body.velocity = Vector2.right * speed;
    }
}
