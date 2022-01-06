using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject lights;

    [SerializeField] private GameStateMagager gameStateMagager;

    private bool used = false;
    public void TurnOnLight()
    {
        if(!used)
        {
            lights.SetActive(true);
            gameStateMagager.OpendDoorsToHell();
            used = true;
        }
    }
}
