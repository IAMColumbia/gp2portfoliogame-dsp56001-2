using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[CreateAssetMenu(fileName = "ColorLightData", menuName = "Data/ScriptableColorLightData", order = 1)]
public class ScriptableColorLight : ScriptableObject
{
    public string objectName = "New ScriptableColorLight Data";
    public bool colorIsRandom = false;
    public Color thisColor = Color.white;
    public Vector3[] spawnPoints = new Vector3[1] { Vector3.zero };
    public float Intensity = 1.0f;
    public float PointLightInnerRadius = 0.0f;
    public float PointLightOuterRadius = 1.0f;
    public Light2D.LightType LightType = Light2D.LightType.Point;
}


