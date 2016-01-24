using UnityEngine;
using System.Collections;

public class GameOverMenuHandler : MAUI {

	void Start () {
		base.Init ();
	}
	
	public void OnReloadButtonClick()
	{
		GameManager.IsGameRunning = false;
		Application.LoadLevel (0);
	}
}
