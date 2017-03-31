using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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

public class riffList{
	public Dictionary<int, List<AudioClip>> riffDict {get; set;}	
	public Dictionary<int, List<AudioClip>> offDict {get; set;}	
	public riffList(){
		riffDict = new Dictionary<int, List<AudioClip>>();
		offDict = new Dictionary<int,List<AudioClip>>();
	}
	
	public void addTrack(int tension, AudioClip clip){
		//Add an audio clip to riff list.
		
		if (riffDict.ContainsKey(tension)){
			riffDict[tension].Add(clip);
		}else{
			List<AudioClip> nw = new List<AudioClip>();
			nw.Add(clip);
			riffDict.Add(tension, nw);
		}
	}
	
	public void offListToList(int tension){
		//Moves the riffs of the appropriate tension level from the offDict to riffDict
		riffDict[tension] = offDict[tension];
		offDict[tension] = new List<AudioClip>();
	}
	
	public List<AudioClip> shuffleList(List<AudioClip> shuffleMe){
		shuffleMe = shuffleMe.OrderBy(x => Random.value).ToList();
		return shuffleMe;
	}
	
	public AudioClip getRiff(int tension){
		//Use this function to obtain a riff with the tension level indicated
		AudioClip a;
		
		if (riffDict[tension].Count == 0){
			offListToList(tension);
			riffDict[tension] = shuffleList(riffDict[tension]);
		}
		
		if (riffDict[tension].Count == 0){
			//Still no songs in the tension level?!?!?!
			return null;
		}
		
		a = riffDict[tension][0];
		riffDict[tension].Remove(a);
		return a;
	}
	
	
}

public static class ProceduralMusicDictionaries{
	/*The purpose of this script is to initialize two dictionaries - one for items and one for items.
	This is a proof of concept and will probably be modularized to be as generic as possible.*/
	
	//The key is the instance ID and the value is the music layer.
	public static riffList riffs = new riffList();
	public static Dictionary<int, musicObject> enemies = new Dictionary<int, musicObject>();
	public static Dictionary<int, musicObject> items = new Dictionary<int, musicObject>();
}
