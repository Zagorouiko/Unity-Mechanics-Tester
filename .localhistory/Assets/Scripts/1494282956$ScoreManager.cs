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
	
	// Update is called once per frame
	void Update () {
	    ScoreUI.text("Score:  " + Score);
    }

    public void AddScore()
    {
        Score++;
    }
}
