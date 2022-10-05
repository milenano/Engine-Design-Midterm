using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public PlayerAction inputAction;

    //singletion creating an instance
    public static PlayerInputController controller;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }


    // Update is called once per frame
    void Awake()
    {
        if (controller == null) controller = this;
        inputAction = new PlayerAction();

    }
}
