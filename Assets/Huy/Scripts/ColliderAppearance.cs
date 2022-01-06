using UnityEngine;

public class ColliderAppearance : MonoBehaviour
{
    public GameObject[] target;
    public bool makesDisappear;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            foreach (GameObject i in target)
            {
                if (makesDisappear)
                    i.SetActive(false);
                else i.SetActive(true);
            }
        }
    }
}
