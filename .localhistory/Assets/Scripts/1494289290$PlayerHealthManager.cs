using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerMaxHealth = 100;
    public int playerCurrentHealth;

	// Use this for initialization
	void Start ()
	{
	    SetMaxHealth();
	}
	
	// Update is called once per frame
	void Update () {
	    if (playerCurrentHealth <= 0)
	    {
	        //GameObject.SetActive(false);
	    }
	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    public void Death()
    {
        if (playerCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
