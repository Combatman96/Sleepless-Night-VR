using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRinging : MonoBehaviour
{
    public GameObject clock;
    private AudioSource clockSound;
    // Start is called before the first frame update
    void Start()
    {
        clockSound = clock.GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            clockSound.enabled = true;
        }
    }
}
