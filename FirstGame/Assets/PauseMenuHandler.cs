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
}
