using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    private EnemyMovement _enemyMovement;
	// Use this for initialization
	void Start ()
	{
	    _enemyMovement = gameObject.GetComponent<EnemyMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
