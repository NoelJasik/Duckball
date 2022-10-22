using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocityZ = moveSpeed * Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, velocityZ);
    }
}
