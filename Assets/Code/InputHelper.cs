using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum InputHelperActions { Action, Aim, Jump, Move, Reload, Shoot }

[RequireComponent(typeof(PlayerInput))]
public abstract class InputHelper : MonoBehaviour
{
    protected PlayerInput playerInput;

    protected virtual void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        playerInput.actions[InputHelperActions.Action.ToString()].performed += Action;
        playerInput.actions[InputHelperActions.Aim.ToString()].performed += Aim;
        playerInput.actions[InputHelperActions.Jump.ToString()].performed += Jump;
        playerInput.actions[InputHelperActions.Move.ToString()].performed += Move;
        playerInput.actions[InputHelperActions.Reload.ToString()].performed += Reload;
        playerInput.actions[InputHelperActions.Shoot.ToString()].performed += Shoot;

        playerInput.actions[InputHelperActions.Action.ToString()].canceled += Action;
        playerInput.actions[InputHelperActions.Aim.ToString()].canceled += Aim;
        playerInput.actions[InputHelperActions.Jump.ToString()].canceled += Jump;
        playerInput.actions[InputHelperActions.Move.ToString()].canceled += Move;
        playerInput.actions[InputHelperActions.Reload.ToString()].canceled += Reload;
        playerInput.actions[InputHelperActions.Shoot.ToString()].canceled += Shoot;
    }

    protected abstract void Action(InputAction.CallbackContext value);
    protected abstract void Aim(InputAction.CallbackContext value);
    protected abstract void Jump(InputAction.CallbackContext value);
    protected abstract void Move(InputAction.CallbackContext value);
    protected abstract void Reload(InputAction.CallbackContext value);
    protected abstract void Shoot(InputAction.CallbackContext value);
}
