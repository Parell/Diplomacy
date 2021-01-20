using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Policy : ScriptableObject
{
    public int implementationTime = 1;
    public int implementationTimeLeft = 1;
    public int pointCost;
    [Range(0, 1)]
    public float value = 0.5f;
    public float costMin;
    public float costMax;
    public float income;
}
