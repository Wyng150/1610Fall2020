using System;
using UnityEngine;
using UnityEngine.Serialization;

public class RotateScript : MonoBehaviour
{
    public float speed = 5f;
    public int count;
    public Vector3 rotationVector3;

    public string password;

        private void Update()
        {
            if (password == "OU812") ;
        {
            print("password correct");
        }
        rotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(rotationVector3);

    }

}