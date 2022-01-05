using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStateMagager : MonoBehaviour
{
    [Header("Doors")]
    public Door mainBedroomDoor;
    public Door bathroomDoor;
    
    [Header("GameObjects")]
    public GameObject bloods;
    public GameObject enemy;
    [Header("SoundFXs")] public AudioSource womanScreem;

    [Header("Components")] 
    public Inventory inventory;
    public TextMeshProUGUI itemlabel;

    public void OpendDoorsToHell(){
        mainBedroomDoor.OpenTheDoor();
        bathroomDoor.OpenTheDoor();
        bloods.SetActive(true);
        womanScreem.Play();
    }


    public void LetThereBeEnemy()
    {
        enemy.SetActive(true);
    }

    public void EscapeTheHouse()
    {
        if(inventory.getKey(3))
        {
            Debug.Log("OK");
            SceneManager.LoadScene( 1, LoadSceneMode.Single);
        }
        else
        {
            itemlabel.SetText("Locked");
        }
    }
    
}
