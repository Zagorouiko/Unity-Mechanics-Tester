using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    private Vector3 distance;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = target.transform.position - transform.position;

        if (distance.x >= 1 && distance.z >= 1)
        {
            agent.SetDestination(target.position);
        }
    }
}
