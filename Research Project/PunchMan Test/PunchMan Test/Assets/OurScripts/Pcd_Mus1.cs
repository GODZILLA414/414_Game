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
    void Start () {
        enemy1 = GetComponent<Aggro414>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
