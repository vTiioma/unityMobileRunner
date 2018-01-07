using UnityEngine;

public class PlatformGeneratorApp : MonoBehaviour {

    private static PlatformGeneratorModel reference;

    protected PlatformGeneratorModel model {
        get {
            if (!reference) {
                reference = new PlatformGeneratorModel();
            }

            return reference;
        }
    }
}
