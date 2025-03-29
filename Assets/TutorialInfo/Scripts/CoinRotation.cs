using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // ความเร็วในการหมุน
    public Vector3 rotationAxis = Vector3.up; // แกนในการหมุน

    void Update()
    {
        // หมุนเหรียญ
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
