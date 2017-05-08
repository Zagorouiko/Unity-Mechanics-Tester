using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int Score;
    public GUIText ScoreUI;
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
        ScoreUI.text("Score:  " + Score);
    }
}
