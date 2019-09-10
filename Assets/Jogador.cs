using ArdJoystick;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public ArdController ardController;

    private void Start()
    {
    }

    private void Update()
    {
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_A))
        {
            Debug.Log("Botão A pressionado (down)");
        }
    }
}