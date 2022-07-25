using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet Type", menuName = "Planet Type")]
public class PlanetType : ScriptableObject
{
    public string planetName;
    public string description;
    public float size;
    public float distanceFromSun;
    public float selfRotationSpeed;
    public float rotationAroundSunSpeed;
}
