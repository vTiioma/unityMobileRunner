using System;

public class PreLoaderModel {
    public event Action OnLoad;

    //public static implicit operator bool ()

    public virtual void Load()
    {
        if (OnLoad != null)
        {
            OnLoad();
        }
    }
}
