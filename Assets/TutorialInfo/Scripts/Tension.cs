using UnityEngine;

public class Tension : MonoBehaviour
{
    [SerializeField] private float tension, mass, acc;
    void Start()
    {
        mass = GetComponent<Rigidbody>().mass;
        acc = 5f;
        tension = mass * (Physics.gravity.y + acc);
    }
    
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(0, tension, 0);
    }
}
