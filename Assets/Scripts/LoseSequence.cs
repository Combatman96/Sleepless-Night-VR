using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoseSequence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadTitle());
    }

    IEnumerator LoadTitle(){
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}
