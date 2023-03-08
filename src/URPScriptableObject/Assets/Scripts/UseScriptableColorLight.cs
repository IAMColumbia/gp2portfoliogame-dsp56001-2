using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using UnityEngine;

public class UseScriptableColorLight : MonoBehaviour
{
    public ScriptableColorLight scriptableColor;
    private List<Light2D> myLights;

    // Use this for initialization
    void Start()
    {
        myLights = new List<Light2D>();
        foreach (Vector3 spawn in scriptableColor.spawnPoints)
        {
            GameObject myLight = new GameObject("Light2D");
            myLight.AddComponent<Light2D>();
            myLight.transform.parent = this.gameObject.transform;
            myLight.transform.position = this.gameObject.transform.position + spawn;
            myLight.GetComponent<Light2D>().lightType = scriptableColor.LightType;
            myLight.GetComponent<Light2D>().intensity = scriptableColor.Intensity;
            myLight.GetComponent<Light2D>().pointLightInnerRadius = scriptableColor.PointLightInnerRadius;
            myLight.GetComponent<Light2D>().pointLightOuterRadius = scriptableColor.PointLightOuterRadius;
            myLight.GetComponent<Light2D>().enabled = false;
            //myLight.GetComponent<Light>()
            if (scriptableColor.colorIsRandom)
            {

                myLight.GetComponent<Light2D>().color =
                    new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            }
            else
            {
                myLight.GetComponent<Light2D>().color = scriptableColor.thisColor;
            }
            myLights.Add(myLight.GetComponent<Light2D>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            foreach (Light2D light in myLights)
            {
                light.enabled = !light.enabled;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            UpdateLights();
        }

    }

    void UpdateLights()
    {
        foreach (var myLight in myLights)
        {
            myLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
