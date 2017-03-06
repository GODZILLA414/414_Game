using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth414 : MonoBehaviour {

	int start = 0;
	public float health = 100f;
    public float timer;
    public float regenRate = 0.5f;

    public GUIStyle progress_empty;
	public GUIStyle progress_full;
    private GUIBarScript barScript;

    //current progress
    public float barDisplay;

	Vector2 pos = new Vector2(10,50);
	Vector2 size = new Vector2(250,50);

	public Texture2D emptyTex;
	public Texture2D fullTex;

    void OnStart()
    {
        //barScript = (GUIBarScript)GameObject.Find("HeartsBar").GetComponent("GUIBarScript");
    }

	void OnGUI()
	{
        if (!barScript)
        {
            barScript = (GUIBarScript)GameObject.Find("HeartsBar").GetComponent("GUIBarScript");
        }
        else
        {
            barScript.Value = health / 100f;
        }
        
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y), emptyTex, progress_empty);

		GUI.Box(new Rect(pos.x, pos.y, size.x, size.y), fullTex, progress_full);

		//draw the filled-in part:
		GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), fullTex, progress_full);

		GUI.EndGroup();
		GUI.EndGroup();
	}

	void Update()
	{
        //regenerate health over time
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = 1f;
            if (health < 100f)
            {
                health += regenRate;
            }
        }


        //script.Value = health / 100f;

        //the player's health
        barDisplay = health/100f;
		if (health <= 0f) { // player is dead
			// print ("end");
			SceneManager.LoadScene("CharacterThirdPerson");
		}
	}

	public void TakeDamage (float amount) {
		health -= amount;

	}
}
