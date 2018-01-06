using UnityEngine;

public class PlayerJumpApp : MonoBehaviour {
    private static PlayerJumpModel reference;

    protected PlayerJumpModel model {
        get {
            if (!reference) {
                reference = new PlayerJumpModel();
            }

            return reference;
        }
    }
}
