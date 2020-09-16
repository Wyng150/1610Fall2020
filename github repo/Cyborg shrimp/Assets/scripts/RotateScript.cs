using System;
using UnityEngine;
using UnityEngine.Serialization;

public class RotateScript : MonoBehaviour
{
    public float speed = 5f;

    [FormerlySerializedAs("RotationVector3")]
    public Vector3 rotationVector3;

    private void Update()
    {
        rotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(rotationVector3);

    }

}