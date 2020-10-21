using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public float speed = 10f;
    public int count;
    public Vector3 RotationVector3;
    public string password;
    private void Update()
    
    {
        if (password == "frank")
        {
            print("correct");
        }
        RotationVector3.y = speed = Time.deltaTime;
        transform.Rotate(RotationVector3);
    }
}