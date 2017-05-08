using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    private float distance;

    public float attackRate = 1f;

    private PlayerHealthManager _playerHealthManager;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _playerHealthManager = GameObject.FindWithTag("Player").GetComponent<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
    }

    public void FindPlayer()
    {
        distance = Vector3.Distance(target.transform.position, transform.position);
        Debug.Log(distance);
        if (distance >= 1.5)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.Stop();
            _playerHealthManager.HurtPlayer(25);
        }
    }
}
