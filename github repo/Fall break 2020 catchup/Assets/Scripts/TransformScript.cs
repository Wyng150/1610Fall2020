using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _moveDirection;

    public TransformScript(Vector3 moveDirection)
    {
        _moveDirection = moveDirection;
    }

    public void Update()
    {
        if (Input.GetButton("Jump"))
        {
            _moveDirection.x = moveSpeed * Time.deltaTime;
                    transform.Translate(_moveDirection);
        }
        else
        {
            _moveDirection.x = -moveSpeed * Time.deltaTime;
            transform.Translate(_moveDirection);
        }
        
    }
}