using UnityEngine;

public class EnemyNavScript : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
