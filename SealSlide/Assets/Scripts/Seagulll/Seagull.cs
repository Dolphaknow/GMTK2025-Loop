using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] [Range(0, 5)] private float travelDistance;

    private void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * travelDistance);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position - Vector3.up * travelDistance);
    }
}
