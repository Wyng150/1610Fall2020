using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    
public float speed = 3f;

public int score = 100;
        // Update is called once per frame
    private void Update()
    {
        var vInput = speed * Time.deltaTime*Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime*Input.GetAxis("Horizontal")  ;
        transform.Translate(hInput ,vInput,0);
    }

    public void Up()
    {
        transform.Translate(0,speed*Time.deltaTime,0 );
    }

    public void Down()
    {
        transform.Translate(0, -speed*Time.deltaTime, 0);
    }
    public void Left()
    {
        transform.Translate(-speed*Time.deltaTime, 0, 0);
    }
    public void Right()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
