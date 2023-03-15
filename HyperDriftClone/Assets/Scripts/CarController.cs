using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed;
    [SerializeField] private float maxSpeed;
    Vector3 moveVec;

    [SerializeField] float steerAngle;
    float dragAmount= 0.99f;

    [SerializeField] float traction;

    private void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
        transform.position += moveVec * Time.deltaTime;

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * steerAngle * Time.deltaTime * moveVec.magnitude);
        moveVec *= dragAmount;
        moveVec = Vector3.ClampMagnitude(moveVec, maxSpeed);
        moveVec = Vector3.Lerp(moveVec.normalized,transform.forward,traction*Time.deltaTime)*moveVec.magnitude;
    }
}
