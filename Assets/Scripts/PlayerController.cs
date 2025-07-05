using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 500);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
