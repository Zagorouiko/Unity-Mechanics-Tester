using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    private static int _score;
    public TextMesh ScoreText;
	// Use this for initialization
	void Start ()
	{
	    _score = 0;
	}
	
	void Update () {
    }

    public void AddScore()
    {
        _score++;
        ScoreText.text = "Score:  " + _score;
    }
}
