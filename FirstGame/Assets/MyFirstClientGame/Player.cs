using UnityEngine;
using System.Collections;

public class Player : PlayerController {

	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.IsGameRunning)
			return;
		Move (Input.GetMouseButton(0));
	}

	void OnTriggerEnter2D()
	{
		GameManager.IsGameRunning = false;
		UIManager.pInstance.pGameMenuHandler.SetVisibility (false);
		UIManager.pInstance.pGameOverMenuHandler.SetVisibility (true);
		UIManager.pInstance.pGameOverMenuHandler.SetFinalScore ();
	}
}
