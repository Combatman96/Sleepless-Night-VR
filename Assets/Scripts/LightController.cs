using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject lights;

    [SerializeField] private GameStateMagager gameStateMagager;


    public void TurnOnLight(){
        lights.SetActive(true);
        gameStateMagager.OpendDoorsToHell();
    }
}
