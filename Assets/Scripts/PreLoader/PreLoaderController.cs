using UnityEngine;
using System;
public class PreLoaderController : PreLoaderApp
{

    public event Action onInput;

    protected virtual void Start()
    {
        InputObserver.onInputDown += OnInputDown;
        InputObserver.onInput += OnInput;
        InputObserver.onInputUp += OnInputUp;
    }

    protected virtual void OnInputUp(InputArgs args)
    {
        if (args is MouseInputArgs)
        {
            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
        else if (args is TouchInputArgs)
        {

            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
    }

    protected virtual void OnInputDown(InputArgs args)
    {
        if (args is MouseInputArgs)
        {
            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
        else if (args is TouchInputArgs)
        {

            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
    }

    protected virtual void OnInput(InputArgs args)
    {
        if (args is MouseInputArgs)
        {
            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
        else if (args is TouchInputArgs)
        {

            if (onInput != null)
            {
                Debug.Log("Input happened!!!");
                onInput();
            }
        }
    }
}
