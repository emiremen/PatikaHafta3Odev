using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteScript : MonoBehaviour
{
    [SerializeField] float rotateSpeed, rotateAroundSpeed;
    
    [SerializeField] GameObject planet;
    void Update()
    {
        transform.Rotate(0, rotateAroundSpeed * Time.deltaTime, 0);
        
        transform.RotateAround(planet.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
