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
	int step = 0; 	//Count frames
	float dist;		//Initialize Distance Variable
		
		
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		step++;
		if (step == 30){
			step = 0;
			foreach(KeyValuePair<int, musicObject> entry in ProceduralMusicDictionaries.enemies){
				//Calculate distance between each enemy.
				dist = Vector3.Distance(transform.position, entry.Value.self.transform.position);
				
				print(dist);

			}
		}
	}
}
