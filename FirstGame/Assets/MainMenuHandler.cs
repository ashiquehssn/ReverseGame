using UnityEngine;
using System.Collections;

public class MainMenuHandler : MAUI {

	// Use this for initialization
	void Start () {
		base.Init ();
	}
	
	public void OnPlayButtonClick()
	{
		SetVisibility (false);
		GameManager.pInstance.StartGame ();
		UIManager.pInstance.pGameMenuHandler.SetVisibility (true);
	}
}
