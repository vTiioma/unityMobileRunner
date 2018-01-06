using UnityEngine;

public class PlayerMovementApp : MonoBehaviour {
    private static PlayerMovementModel reference;

    protected PlayerMovementModel model {
        get {
            if (!reference) {
                reference = new PlayerMovementModel();
            }

            return reference;
        }
    }
}
