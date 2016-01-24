using UnityEngine;
using System.Collections;

public class GameMenuHandler : MAUI {

	// Use this for initialization
	void Start () {
		base.Init ();
	}

	public void OnPauseButtonClick()
	{
		SetVisibility (false);
		UIManager.pInstance.pPauseMenuHandler.SetVisibility (true);
		GameManager.pInstance.PauseGame();
	}
}
