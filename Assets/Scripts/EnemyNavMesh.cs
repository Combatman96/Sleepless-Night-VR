using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    [SerializeField] private Transform target;

    private void Awake()
    {
        navMeshAgent =  GetComponent<NavMeshAgent>(); 
    }

    private void Update()
    {
        navMeshAgent.destination = target.position;
    }

}
