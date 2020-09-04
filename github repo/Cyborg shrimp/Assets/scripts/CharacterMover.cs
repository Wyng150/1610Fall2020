using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{




public float speed = 7f;

public int score = 100;
        // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed*Time.deltaTime ,0,0);
    }
}
