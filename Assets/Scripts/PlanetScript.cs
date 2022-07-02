using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    
    [SerializeField] float rotateSpeed, rotateAroundSpeed;
    float travelledDistance, tourCount;

    [SerializeField] Transform rotatingTarget;

    void Update()
    {
        transform.Rotate(0, rotateAroundSpeed * Time.deltaTime, 0);
        transform.RotateAround(rotatingTarget.position, Vector3.up, rotateSpeed * Time.deltaTime);

        travelledDistance += rotateSpeed * Time.deltaTime;
        if (travelledDistance > 360)
        {
            travelledDistance = 0f;
         tourCount++;
            Debug.Log(gameObject.name + "'s. Total tours: " + tourCount);
        }
    }
}
