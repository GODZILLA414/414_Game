using UnityEngine;
using System.Collections;

public class AchievementDisplayer414 : MonoBehaviour {

    public GUIStyle aDisplay;

	private float timer = 0f;

    private bool show = false;
    private string achievementText = "testing achievement";

    private bool showedexitmessage = false;
	private bool showed1fuelcell = false;
	private bool showed2fuelcell = false;


    void OnGUI()
    {

        if (timer < 7f && show)
        {

            GUI.backgroundColor = Color.black;
            GUI.Box(new Rect(350, 750, Screen.width - 400 * 2, 20), achievementText, aDisplay);

        }
        else
        {
            show = false;
        }

		//Show fuel cell indicator
		int fuelcells = Assets.VRBike.AchievementManager.fuelCollected;
		GUI.color = Color.white;
		if (fuelcells == 0) {
			GUI.Box (new Rect (40, 450, 200, 20), " Fuel Cells: NONE ", aDisplay);
		} else {
			GUI.Box (new Rect (40, 450, 200, 20), " Fuel Cells: " + fuelcells.ToString() +  "/3 ", aDisplay);
		}



			
    }

	// Use this for initialization
	void Start () {

        Assets.VRBike.AchievementManager.collected3fuelcells = false;
        Assets.VRBike.AchievementManager.fuelCollected = 0;
		Assets.VRBike.AchievementManager.gotonecell = false;
		Assets.VRBike.AchievementManager.gottwocell = false;


    }

	// Update is called once per frame
	void Update () {

		
		if (showed1fuelcell != Assets.VRBike.AchievementManager.gotonecell)
		{
			showed1fuelcell = true;
			achievementText = "1/3 Fuel Cells Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed2fuelcell != Assets.VRBike.AchievementManager.gottwocell)
		{
			showed2fuelcell = true;
			achievementText = "2/3 Fuel Cells Collected";
			show = true;
			timer = 0;
			return;
		}

        if (showedexitmessage != Assets.VRBike.AchievementManager.collected3fuelcells)
        {
            showedexitmessage = true;
            achievementText = "You got the fuel cells! Follow the compass to the space ark to escape!";
            show = true;
            timer = 0;
            return;
        }

    }
}
