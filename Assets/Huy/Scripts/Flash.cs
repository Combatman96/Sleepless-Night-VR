using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flash : MonoBehaviour
{
    public GameObject[] flickeringLights;

    Light lights;
    public float minFlickerTime = 0.1f;
    public float maxFlickerTime = 0.4f;

    private void Start()
    {
        flickeringLights = GameObject.FindGameObjectsWithTag("FlickeringLight");
        for (int i = 0; i < flickeringLights.Length; i++)
        {
            lights = flickeringLights[i].GetComponent<Light>();
            StartCoroutine(Flicker(lights));
        }
    }

    IEnumerator Flicker(Light lights)
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minFlickerTime, maxFlickerTime));
            lights.enabled = !lights.enabled;
        }
    }
}