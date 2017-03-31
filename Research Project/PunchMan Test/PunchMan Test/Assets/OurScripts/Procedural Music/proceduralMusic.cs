using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralMusic : MonoBehaviour {

	/*
	Right now the algorithm should in theory look at the distances between the player object and the enemy/item objects.
	It will then assign music layer
	0 - off, no music
	1 - far, use softer toned music
	2 - middle-ish distances, use more dramatic music snippets
	3 - near, use very dramatic music snippets
	
	The volume of each clip should be directly tied to the distance to the enemy.
	The script will only check for changes in enemy positioning once per second instead of every frame.
	This should remove lag.
	*/
	// Use this for initialization
	
	//Initialize Variables
    public AudioSource audSrc;	
	
	// === Variables For Procedural Music === //
	int step = 0; 			//Count frames
	float dist;     		//Initialize Distance Variable
	int numTension = 4;		//Number of tension levels
	
	public riffList riffs = new riffList();	//Define riffList, see proceduralMusicInitialize.cs for more details
		
	void Start () {
		//Add Songs Here
		riffs.addTrack(0, Resources.Load<AudioClip>("OurScripts/OurMusic/Base_Beat"));
        audSrc = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		step++;
		if (step == 30){
			step = 0;
			//Write Behaviours we want here!
			enemyProx(10);
		}
	}
	
	void enemyProx(int proximity){
		
		foreach(KeyValuePair<int, musicObject> entry in ProceduralMusicDictionaries.enemies){
			//Calculate distance between each enemy.
			audSrc.clip = riffs.getRiff(0);
			
			if (entry.Value.type == "enemy") {
				dist = Vector3.Distance(transform.position, entry.Value.self.transform.position);
				if (dist < proximity && audSrc.isPlaying == false){
					audSrc.Play();
				} else {
					audSrc.Stop();
				}
			} else{
				//Item
			}
		}
	}
	
	void parameterMusic(int parameter, int type, int min, int max){
		/*For things such as health or # of items collected
		Define multiple types such as if higher more tension or higher less tension.
		Types:
		0 - Default, Higher amount = more tension
		1 - Less amount = more tension
		
		Must define max and min for the parameter
		*/
		
	}
}
