using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherMover : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;

    private void Update()
    {
        moveDirection.x = moveSpeed * Time.deltaTime;
    }
}
