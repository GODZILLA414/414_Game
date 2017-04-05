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
	private bool showed3fuelcell = false;
	private bool showed4fuelcell = false;
	private bool showed5fuelcell = false;
	private bool showed6fuelcell = false;
	private bool showed7fuelcell = false;


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
			GUI.Box (new Rect (40, 450, 200, 20), " Priceless Artifacts Stolen: NONE ", aDisplay);
		} else {
			GUI.Box (new Rect (40, 450, 200, 20), " Priceless Artifacts Stolen: " + fuelcells.ToString() +  "/8 ", aDisplay);
		}



			
    }

	// Use this for initialization
	void Start () {

        Assets.VRBike.AchievementManager.collected8fuelcells = false;
        Assets.VRBike.AchievementManager.fuelCollected = 0;
		Assets.VRBike.AchievementManager.gotonecell = false;
		Assets.VRBike.AchievementManager.gottwocell = false;
		Assets.VRBike.AchievementManager.gotthreecell = false;
		Assets.VRBike.AchievementManager.gotfourcell = false;
		Assets.VRBike.AchievementManager.gotfivecell = false;
		Assets.VRBike.AchievementManager.gotsixcell = false;
		Assets.VRBike.AchievementManager.gotsevencell = false;

    }

	// Update is called once per frame
	void Update () {

		
		if (showed1fuelcell != Assets.VRBike.AchievementManager.gotonecell)
		{
			showed1fuelcell = true;
			achievementText = "1/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed2fuelcell != Assets.VRBike.AchievementManager.gottwocell)
		{
			showed2fuelcell = true;
			achievementText = "2/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed3fuelcell != Assets.VRBike.AchievementManager.gotthreecell)
		{
			showed3fuelcell = true;
			achievementText = "3/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed4fuelcell != Assets.VRBike.AchievementManager.gotfourcell)
		{
			showed4fuelcell = true;
			achievementText = "4/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed5fuelcell != Assets.VRBike.AchievementManager.gotfivecell)
		{
			showed5fuelcell = true;
			achievementText = "5/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed6fuelcell != Assets.VRBike.AchievementManager.gotsixcell)
		{
			showed6fuelcell = true;
			achievementText = "6/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

		if (showed7fuelcell != Assets.VRBike.AchievementManager.gotsevencell)
		{
			showed7fuelcell = true;
			achievementText = "7/8 Artifacts Collected";
			show = true;
			timer = 0;
			return;
		}

        if (showedexitmessage != Assets.VRBike.AchievementManager.collected8fuelcells)
        {
            showedexitmessage = true;
            achievementText = "You stole all the artifacts! Find the hidden opening to escape!";
            show = true;
            timer = 0;
            return;
        }

    }
}
