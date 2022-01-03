using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject lights;

    public void TurnOnLight(){
        lights.SetActive(true);
    }
}
