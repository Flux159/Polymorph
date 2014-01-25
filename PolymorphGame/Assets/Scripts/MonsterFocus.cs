﻿using UnityEngine;
using System.Collections;

public class MonsterFocus : MonoBehaviour, IFocusable
{
	public bool alive = true;
	public GameObject newPlayerController;
	
	public bool OnFocus ()
	{
		Instantiate (newPlayerController, transform.gameObject.transform.position, transform.gameObject.transform.rotation);
			transform.gameObject.SetActive (false);
		//GameObject.Destroy (transform.gameObject, 2.0f);
		return true;
	}

	public bool IsFocusable ()
	{
		return alive;
	}
}