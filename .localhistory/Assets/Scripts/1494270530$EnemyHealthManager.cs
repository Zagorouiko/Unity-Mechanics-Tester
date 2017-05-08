using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

	// Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (health <= 0)
	    {
	        Destroy(gameObject);
	    }
	}
}
