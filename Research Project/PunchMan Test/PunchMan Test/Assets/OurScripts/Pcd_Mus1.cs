using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcd_Mus1 : MonoBehaviour {
    // Use this for initialization
    private Aggro414 enemy1;            //Primarily used to get the distance from enemy
    
    private static List<char> musicLvl1;        //Music track files will be explicitly called and organized based on 'level'
    private static List<char> musicLvl2;
    private static List<char> musicLvl3;
    private static List<char> musicLvl4;

    private float distance;
    void Start () {
        enemy1 = GetComponent<Aggro414>();
	}
	
	// Update is called once per frame
	void Update () {
        //Promity Cue method 1: Distance *********************
        distance = enemy1.playerDistance;           //TODO: Figure out distance scale and assign condition statements accordingly

        if (distance >= 500) { }//select randomly from one of the tracks from lvl1
        else if (distance >= 250 && distance < 500) { }//select randomly one of the tracks from lvl2
        else if (distance >= 50 && distance < 250) { }//select randomly one of the tracks from lvl3
        else { }//select ranfomly from one of the tracks from lvl4
        //****************************************************

        
	}
}
