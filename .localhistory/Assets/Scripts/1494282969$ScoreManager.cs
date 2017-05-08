using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int Score;
    public TextMesh ScoreUI;
	// Use this for initialization
	void Start ()
	{
	    Score = 0;
	}
	
	void Update () {
    }

    public void AddScore()
    {
        Score++;
        ScoreUI.text("Score:  " + Score);
    }
}
