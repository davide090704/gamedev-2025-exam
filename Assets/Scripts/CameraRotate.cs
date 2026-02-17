using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.UIElements;

public class CameraRotate : MonoBehaviour
{
    private Vector3 startPosition;
    public bool isMoved;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMoved = false;       
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.W))
        {
            if (!isMoved)
            {
                transform.Rotate(Vector3.forward, -180);
                isMoved = true;
            }
        }
    if (Input.GetKey(KeyCode.S))
        {
            if (isMoved)
            {
                transform.Rotate (Vector3.forward, 180);
                isMoved = false;
            }
        }
    }
}
