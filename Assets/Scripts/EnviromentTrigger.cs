using UnityEngine;

public class EnviromentTrigger : MonoBehaviour
{
    public AudioSource soundFx;
    private BoxCollider boxCollider;
    private bool played = false;

    private void Start() {
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player" && !played)
        {
            soundFx.Play();
            played = true;
            boxCollider.enabled = false;
        }
    }
}
