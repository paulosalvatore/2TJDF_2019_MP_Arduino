using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteArduino : MonoBehaviour
{
    public ArdJoystick.ArdController ardController;

    private void Update()
    {
        if (ardController.GetKeyDown(ArdJoystick.ArdKeyCode.BUTTON_A))
        {
            // Action for Button A
        }
    }
}