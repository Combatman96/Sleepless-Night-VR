using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject lights;

    [SerializeField] private GameStateMagager gameStateMagager;

    [SerializeField] private AudioSource audioSource;
    private BoxCollider boxCollider;
    private bool used;

    private void Start() {
        used = false;
        boxCollider = GetComponent<BoxCollider>();
    }
    public void TurnOnLight()
    {
        if(!used)
        {
            lights.SetActive(true);
            audioSource.Play();
            gameStateMagager.OpendDoorsToHell();
            boxCollider.enabled = false;
            used = true;
        }
    }
}
