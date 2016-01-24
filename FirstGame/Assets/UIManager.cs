using UnityEngine;
using System.Collections;

public class UIManager : AGComponent {

	[SerializeField] private MainMenuHandler mainMenuHandler;
	[SerializeField] private GameMenuHandler gameMenuHandler;
	[SerializeField] private PauseMenuHandler pauseMenuHandler;
	[SerializeField] private GameOverMenuHandler gameOverMenuHandler;


	public MainMenuHandler pMainMenuHandler {get {return mainMenuHandler;}}
	public GameMenuHandler pGameMenuHandler {get {return gameMenuHandler;}}
	public PauseMenuHandler pPauseMenuHandler {get {return pauseMenuHandler;}}
	public GameOverMenuHandler pGameOverMenuHandler {get {return gameOverMenuHandler;}}


	private static UIManager mInstance = null;
	public static UIManager pInstance {get {return mInstance;}}
	
	
	UIManager()
	{
		mInstance = this;
	}
}
