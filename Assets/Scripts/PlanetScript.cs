using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    [SerializeField] PlanetType planetType;
    float travelledDistance, tourCount;

    [SerializeField] Transform rotatingTarget;

    private void Start()
    {

        transform.localScale = new Vector3(planetType.size, planetType.size, planetType.size) / 1000;
        transform.position = new Vector3(0,0,-planetType.distanceFromSun * 50);
    }

    void Update()
    {
        transform.Rotate(0, planetType.selfRotationSpeed / 50 * Time.deltaTime, 0);
        transform.RotateAround(rotatingTarget.position, Vector3.up, planetType.rotationAroundSunSpeed * Time.deltaTime);

        travelledDistance += planetType.selfRotationSpeed * Time.deltaTime;
        if (travelledDistance > 360)
        {
            travelledDistance = 0f;
         tourCount++;
            Debug.Log(gameObject.name + "'s. Total tours: " + tourCount);
        }
    }
}
