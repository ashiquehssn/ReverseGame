﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public int score = 0;
//	public GUIText ScoreText;
	public Text m_scoreText;
	public Text m_highScoreText;
	int count;

	public static ScoreManager _Instance;
	// Use this for initialization
	void Start () {

		if (_Instance == null)
			_Instance = this;
		//PlayerPrefs.SetInt("IsFirst", 1);
		SetIsFirst ();
		m_highScoreText.text = "Best " + PlayerPrefs.GetInt("HighScore");
	}

	void SetIsFirst()
	{
		if (PlayerPrefs.GetInt ("IsFirst") != 0) 
		{
			PlayerPrefs.SetInt("IsFirst", 0);
			PlayerPrefs.SetInt("HighScore", 0);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameManager.IsGameRunning && count >= 15) {
			score++;
			setScore();
		}
		if (count == 15)
			count = 0;
		else
			count++;
	}

	void setScore()
	{
		m_scoreText.text = "" + score;
		if(PlayerPrefs.GetInt("HighScore") < score)
		{
			PlayerPrefs.SetInt("HighScore", score);
			m_highScoreText.text = "Best " + PlayerPrefs.GetInt("HighScore");
		}
	}
}
