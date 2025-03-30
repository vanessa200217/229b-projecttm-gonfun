using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // หมุนเหรียญ
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
