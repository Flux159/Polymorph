﻿using UnityEngine;
using System.Collections;

public class BatCharacter : MonsterFocus {

	public AudioClip batDeath;

	public override bool OnFocus() {
		base.OnFocus ();

		ShowWaterTiles ();
		GameObject.Find ("Directional light").GetComponent<LightDimmer> ().DimLights ();
		UnDoFog ();

		return true;
	}

	void OnDestroy() {
		audio.clip = batDeath;
		audio.Play ();
	}
}
