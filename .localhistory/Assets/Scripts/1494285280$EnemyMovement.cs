using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform target;
    private Rigidbody rb;
    private Renderer renderer;

	// Use this for initialization
	void Start ()
	{
	    renderer.GetComponent<Renderer>();
	    rb.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
