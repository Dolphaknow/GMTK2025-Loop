using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    [SerializeField] private float maxHeight;
    private float current;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void Update()
    {
        current += Time.deltaTime;
        current %= 1;
        rb.velocity = new Vector3(rb.velocity.x, Mathf.PingPong(current, maxHeight), rb.velocity.z);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position + Vector3.up * maxHeight, 0.5f);
    }
}
