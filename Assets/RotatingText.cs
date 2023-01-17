using UnityEngine;

public class RotatingText : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    private float _horizontalInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, _horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
