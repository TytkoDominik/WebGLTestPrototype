using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButtonController : MonoBehaviour
{

	[SerializeField] private GameObject _buttons;
	
	void Start () {
		_buttons.SetActive(false);
		GetComponent<OnPointerDownButton>().AddOnPointerDownListener(OnClick);				
	}

	private void OnClick()
	{
		_buttons.SetActive(true);
		this.gameObject.SetActive(false);
		SetFullScreenOn();
	}

	private void SetFullScreenOn()
	{
		Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
	}
}
