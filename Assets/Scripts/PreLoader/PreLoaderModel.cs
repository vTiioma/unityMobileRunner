using System;
using UnityEngine;

[RequireComponent(typeof(PreLoaderController))]
public class PreLoaderModel
{
    public event Action onLoad;

    [SerializeField]
    PreLoaderController preloadControl;

    protected virtual void Start()
    {
        preloadControl.onInput += Load;
    }

    public static implicit operator bool(PreLoaderModel reference)
    {
        return reference != null;
    }

    public virtual void Load()
    {
        if (onLoad != null)
        {
            onLoad();
        }
    }
}
