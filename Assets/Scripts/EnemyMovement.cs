﻿using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    private float distance;

    public float attackRate = .10f;
    private float nextAttack;

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
        if (_playerHealthManager == null) return;
        distance = Vector3.Distance(target.transform.position, transform.position);

        if (distance >= 1.5)
        {
            agent.SetDestination(target.position);
        }
        //delay not working?
        else if (distance <= 1.5 && Time.time > nextAttack)
        {
            nextAttack = Time.time + attackRate;
            agent.Stop();
            _playerHealthManager.HurtPlayer(25);
        }
    }
}
