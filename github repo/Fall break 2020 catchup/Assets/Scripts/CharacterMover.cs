using System;
using UnityEngine;
public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 moveDirection;

    private void Update()
    {
        controller.Move(moveDirection);
    }
}
