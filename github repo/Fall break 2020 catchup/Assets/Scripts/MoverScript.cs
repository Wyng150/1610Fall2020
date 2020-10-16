using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 1f;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is my World Now!");
    }

    // Update is called once per frame
    void Update()
    {
        x = speed*Input.GetAxis("Horizontal");
        y = speed*Input.GetAxis("Vertical");
        transform.Translate(x,y,z);
    }
}
