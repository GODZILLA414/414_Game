using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Store instance ID and initialize the music layer
		musicObject me = new musicObject(gameObject, "enemy");
		ProceduralMusicDictionaries.enemies.Add(GetInstanceID(), me);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
