using UnityEngine;

public class TurnOffSound : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void TurnItOff()
    {
        audioSource.enabled = false;
    }
}
