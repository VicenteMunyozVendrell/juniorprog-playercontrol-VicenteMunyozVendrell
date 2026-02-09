using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float turnSpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
}
