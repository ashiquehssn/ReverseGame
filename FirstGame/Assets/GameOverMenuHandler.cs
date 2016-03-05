using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverMenuHandler : MAUI {

	public Text m_scoreText;
	void Start () {
		base.Init ();
	}
	
	public void OnHomeButtonClick()
	{
		GameManager.IsGameRunning = false;
		Application.LoadLevel (0);
	}

	public void SetFinalScore()
	{
		m_scoreText.text = "Score : " + ScoreManager._Instance.score;
	}

	public void OnRestartButtonClick()
	{
		ScoreManager._Instance.score = 0;
		DestroyObstacle ();

		SetVisibility (false);
		GameManager.pInstance.StartGame ();
		UIManager.pInstance.pGameMenuHandler.SetVisibility (true);
	}

	void DestroyObstacle()
	{
		GameObject [] obj = GameObject.FindGameObjectsWithTag ("Obstacle");

		for (int i = 0; i < obj.Length; i++) 
		{
			if(obj[i] != null)
				Destroy(obj[i]);
		}
	}



}
