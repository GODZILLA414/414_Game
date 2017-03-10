using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralMusicInitialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class musicObject{
	//Self is the game object being referred to
	//musicValue initializes to 0 and can be changed to reflect the distance from the object to the player object
	//type is a tag you can use to define if it is an item or enemy or something else.
	public GameObject self {get; set;}
	public int musicValue {get; set;}
	public string type {get; set;}
    public musicObject(){}
	public musicObject(GameObject s, string t){
		self = s;
		musicValue = 0;
		type = t;
	}
    
	
}

public static class ProceduralMusicDictionaries{
	/*The purpose of this script is to initialize two dictionaries - one for items and one for items.
	This is a proof of concept and will probably be modularized to be as generic as possible.*/
	
	//The key is the instance ID and the value is the music layer.
	public static Dictionary<int, musicObject> enemies = new Dictionary<int, musicObject>();
	public static Dictionary<int, musicObject> items = new Dictionary<int, musicObject>();
}
