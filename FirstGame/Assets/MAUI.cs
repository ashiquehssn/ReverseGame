using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public enum UiType
{
	BUTTON , CHECKBOX, TEXTBOX
}

public abstract class MAUI : AGComponent {

	Dictionary<string , Button> uiButtons = new Dictionary<string, Button>();
	Dictionary<string , Toggle> uiCheckBox = new Dictionary<string, Toggle>();
	Dictionary<string , InputField> uiTextBox = new Dictionary<string, InputField>();

	public void Init()
	{
		GetAllButtonsFromCanavas ();
		GetAllCheckBoxFromCanavas ();
		GetAllTextBoxFromCanavas ();
	}

	private void GetAllButtonsFromCanavas()
	{
		Button[] tButtons = GetComponentsInChildren<Button>();
		foreach(Button btn in tButtons)
		{
			if(!uiButtons.ContainsKey(btn.gameObject.name))
				uiButtons.Add(btn.gameObject.name,btn);
			else
				Debug.Log("Canavas alreardy contains the button  "+btn.gameObject.name);
		}
	}

	private void GetAllCheckBoxFromCanavas()
	{
		Toggle[] tCheckBox = GetComponentsInChildren<Toggle>();
		foreach(Toggle cb in tCheckBox)
		{
			if(!uiCheckBox.ContainsKey(cb.gameObject.name))
				uiCheckBox.Add(cb.gameObject.name,cb);
			else
				Debug.Log("Canavas alreardy contains the checkBox  "+cb.gameObject.name);
		}
	}

	private void GetAllTextBoxFromCanavas()
	{
		InputField[] tTextBox = GetComponentsInChildren<InputField>();
		foreach(InputField input in tTextBox)
		{
			if(!uiTextBox.ContainsKey(input.gameObject.name))
				uiTextBox.Add(input.gameObject.name,input);
			else
				Debug.Log("Canavas alreardy contains the TextBox  "+input.gameObject.name);
		}
	}

	public Button GetButton(string name)
	{
		if (uiButtons.ContainsKey (name))
			return uiButtons [name];
		else {
			Debug.LogError ("Button Not found...  " + name);
			return null;
		}
	}

	public Toggle GetCheckBox(string name)
	{
		if (uiCheckBox.ContainsKey (name))
			return uiCheckBox [name];
		else {
			Debug.LogError ("CheckBox Not found...  " + name);
			return null;
		}
	}

	public InputField GetTextBox(string name)
	{
		if (uiTextBox.ContainsKey (name))
			return uiTextBox [name];
		else {
			Debug.LogError ("CheckBox Not found...  " + name);
			return null;
		}
	}

	public virtual void SetVisibility(string name ,bool status,UiType type)
	{
		switch(type)
		{
		case UiType.BUTTON:
			uiButtons[name].gameObject.SetActive(status);
			break;
		}
	}

	public virtual void SetVisibility(bool status)
	{
		canvas.enabled = status;
	}

	public void SetInteractive(string name , bool status, UiType type)
	{
		switch(type)
		{
		case UiType.BUTTON:
			uiButtons[name].interactable = status;
			break;
		case UiType.CHECKBOX:
			uiCheckBox[name].interactable = status;
			break;
		case UiType.TEXTBOX:
			uiTextBox[name].interactable = status;
			break;
		}
	}

	public bool IsInteractive(string name ,UiType type)
	{
		bool interactive = false;
		switch(type)
		{
		case UiType.BUTTON:
			interactive = uiButtons[name].interactable;
			break;
		case UiType.CHECKBOX:
			interactive = uiCheckBox[name].interactable;
			break;
		case UiType.TEXTBOX:
			interactive =  uiTextBox[name].interactable;
			break;
		}
		return interactive;
	}
}
