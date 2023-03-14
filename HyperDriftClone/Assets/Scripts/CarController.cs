using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed;
    Vector3 moveVec;

    private void Update()
    {
        moveVec += transform.forward * carSpeed * Time.deltaTime;
    }
}
