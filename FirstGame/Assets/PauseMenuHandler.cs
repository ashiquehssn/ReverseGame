using UnityEngine;
using System.Collections;

public class PauseMenuHandler : MAUI {

	// Use this for initialization
	void Start () {
		base.Init ();
	}

	public void OnResumeButtonClick()
	{
		SetVisibility (false);
		UIManager.pInstance.pGameMenuHandler.SetVisibility (true);
		GameManager.pInstance.ResumeGame();
	}

	public void OnHomeButtonClick()
	{
		GameManager.IsGameRunning = false;
		Application.LoadLevel (0);
	}

	public void OnRestartButtonClick()
	{
		DestroyObstacle ();
		ScoreManager._Instance.ResetTheScore ();
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
