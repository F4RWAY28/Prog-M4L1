using UnityEngine;

public class SpinController : MonoBehaviour
{
    public float spinSpeed = 0f;
    public float acceleration = 50f;
    public float deceleration = 50f;
    private bool stopAccelerating = false;

    public Vector3 offset = new Vector3(0f, 0f, 999f); // Offset from original pivot
    private Vector3 pivotPoint;

    void Start()
    {
        // Calculate the initial pivot point
        pivotPoint = transform.position + transform.rotation * offset;
    }

    void Update()
    {
        float currentAcceleration = acceleration;

        // Multiply acceleration when holding W
        if (Input.GetKey(KeyCode.W) && !stopAccelerating)
        {
            currentAcceleration *= 50f; // You can tweak this multiplier
        }

        if (!stopAccelerating)
        {
            spinSpeed += currentAcceleration * Time.deltaTime;
        }
        else
        {
            // Gradually slow down
            if (spinSpeed > 0f)
            {
                spinSpeed -= deceleration * Time.deltaTime;
                spinSpeed = Mathf.Max(spinSpeed, 0f);
            }
        }

        // Rotate around a pivot point (offset from the object)
        transform.RotateAround(pivotPoint, Vector3.up, spinSpeed * Time.deltaTime);

        // Press Space to stop accelerating
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stopAccelerating = true;
        }
    }
}