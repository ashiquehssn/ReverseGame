using UnityEngine;
using System.Collections;

public class GameManager : AGComponent {
	public Player player;
	private static GameManager mInstance = null;

	public static GameManager pInstance {get {return mInstance;}}
	public static bool IsGameRunning = false;

	GameManager()
	{
		mInstance = this;
	}

	public void StartGame()
	{
		player.enabled = true;
		IsGameRunning = true;

	}
	public void PauseGame()
	{
		player.enabled = false;
		IsGameRunning = false;

	}
	public void ResumeGame()
	{
		player.enabled = true;
		IsGameRunning = true;
	}

}
