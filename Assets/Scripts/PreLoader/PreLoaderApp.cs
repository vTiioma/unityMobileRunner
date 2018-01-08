using UnityEngine;

public class PreLoaderApp : MonoBehaviour
{
    private static PreLoaderModel reference;

    protected PreLoaderModel model
    {
        get
        {
            if (!reference)
            {
                reference = new PreLoaderModel();
            }
            return reference;
        }
    }
}
