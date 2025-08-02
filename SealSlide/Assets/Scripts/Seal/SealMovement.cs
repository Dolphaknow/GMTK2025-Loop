using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
public class SealMovement : MonoBehaviour
{
    [SerializeField] private float sealSpeed;
    [SerializeField] private SplineContainer movementSpline;
    [SerializeField] [Range(0,0.5f)] private float percentSpeed;
    private float currentPercent = 0f;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //on the update, increase number by Time.DeltaTime
        //evaluate the x and z

        currentPercent += Time.deltaTime * percentSpeed;
        currentPercent %= 1f;

        Vector3 currentSplinePos = movementSpline.EvaluatePosition(currentPercent);
        Vector3 currentSplineRot = movementSpline.EvaluateTangent(currentPercent);
        Vector3 currentSplineAcc = movementSpline.EvaluateAcceleration(currentPercent);
        transform.forward = currentSplineRot;
        //rb.velocity = transform.forward.normalized;
        transform.position = new Vector3(currentSplinePos.x, transform.position.y, currentSplinePos.z);
        //rb.velocity = Vector3.MoveTowards(transform.position, currentSplinePos, 0.1f);
    }
}
