using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int Score;
	// Use this for initialization
	void Start ()
	{
	    Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore()
    {
        Score++;
        Debug.Log("Score:" + Score);
    }
}
