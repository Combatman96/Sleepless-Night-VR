using UnityEngine;

public class EnviromentTrigger : MonoBehaviour
{
    public AudioSource soundFx;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            soundFx.Play();
        }
    }
}
