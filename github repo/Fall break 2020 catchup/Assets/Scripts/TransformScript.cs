using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 RotationVector3;
    private void Update()
    {
        if (expr)
        {
            
        }
        RotationVector3.y = speed = Time.deltaTime;
        transform.Rotate(RotationVector3);
    }
}