using UnityEngine;

public class PlayerJumpController : PlayerJumpApp {

    protected virtual void Start() {
        InputObserver.onInputDown += OnInputDown;
        InputObserver.onInput += OnInput;
        InputObserver.onInputUp += OnInputUp;
    }

    protected virtual void OnInputDown(InputArgs args) {
        // jump
        if (args is MouseInputArgs) {
            MouseInputArgs mouseArgs = (MouseInputArgs)args;
            //Debug.Log("Mouse position on press down " + mouseArgs.position.ToString() + ", at " + mouseArgs.time.ToString("0.00") + " seconds.");
            model.Jump(1);
        } else if (args is TouchInputArgs) {
            TouchInputArgs touchArgs = (TouchInputArgs)args;
            //Debug.Log("Touch position on press down " + touchArgs.position.ToString() + ", at " + touchArgs.time.ToString("0.00") + " seconds.");
            model.Jump(1);
        }
    }

    protected virtual void OnInput(InputArgs args) {
        // glide
        if (args is MouseInputArgs) {
            MouseInputArgs mouseArgs = (MouseInputArgs)args;
            //Debug.Log("Mouse position is " + mouseArgs.position.ToString() + ", with a change in position of " + mouseArgs.delta.ToString() + ", at " + mouseArgs.time.ToString("0.00") + " seconds.");
        } else if (args is TouchInputArgs) {
            TouchInputArgs touchArgs = (TouchInputArgs)args;
            //Debug.Log("Touch position is " + touchArgs.position.ToString() + ", with a change in position of " + touchArgs.delta.ToString() + ", at " + touchArgs.time.ToString("0.00") + " seconds.");
        }
    }

    protected virtual void OnInputUp(InputArgs args) {
        // end glide
        if (args is MouseInputArgs) {
            MouseInputArgs mouseArgs = (MouseInputArgs)args;
            //Debug.Log("Mouse position on release " + mouseArgs.position.ToString() + ", with a change in position of " + mouseArgs.delta.ToString() + ", at " + mouseArgs.time.ToString("0.00") + " seconds.");
        } else if (args is TouchInputArgs) {
            TouchInputArgs touchArgs = (TouchInputArgs)args;
            //Debug.Log("Touch position on release " + touchArgs.position.ToString() + ", with a change in position of " + touchArgs.delta.ToString() + ", at " + touchArgs.time.ToString("0.00") + " seconds.");
        }
    }
}
