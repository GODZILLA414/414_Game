using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    int start = 3;

    public bool fuel1 = false;
    public bool fuel2 = false;
    public bool fuel3 = false;
    public bool fuel4 = false;
    public bool fuel5 = false;
    public bool fuel6 = false;
    public bool fuel7 = false;
    public bool fuel8 = false;
    public bool fuel9 = false;

    int showMsg1 = 0;
    int showMsg2 = 0;
    int showMsg3 = 0;

    int numberOfFuels = 0;

    public void setFuel1(bool value)
    {
        fuel1 = value;
    }

    public void setFuel2(bool value)
    {
        fuel2 = value;
    }

    public void setFuel3(bool value)
    {
        fuel3 = value;
    }

    public void setFuel4(bool value)
    {
        fuel4 = value;
    }

    public void setFuel5(bool value)
    {
        fuel5 = value;
    }

    public void setFuel6(bool value)
    {
        fuel6 = value;
    }

    public void setFuel7(bool value)
    {
        fuel7 = value;
    }

    public void setFuel8(bool value)
    {
        fuel8 = value;
    }

    public void setFuel9(bool value)
    {
        fuel9 = value;
    }


    void Update()
    {
        if (fuel1 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels = numberOfFuels+1;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel2 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel3 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel4 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel5 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel6 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel7 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel8 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }

        if (fuel9 == true)
        {
            if (showMsg1 == 0)
            {
                showMsg1 = 1;
                numberOfFuels++;
            }
            else if (showMsg2 == 0)
            {
                showMsg2 = 1;
                numberOfFuels++;
            }
            else if (showMsg3 == 0)
            {
                showMsg3 = 1;
                numberOfFuels++;
            }
        }
    }

    void OnGUI()
    {
        if (showMsg1 == 1)
        {
            showMsg1 = 2;
            string printMsg = "Got " + numberOfFuels + "/3 fuels!";
            print(printMsg);

            // NEED TODO: Display properly in-game
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), printMsg);
        }
        if (showMsg2 == 1)
        {
            showMsg2 = 2;
            string printMsg = "Got " + numberOfFuels + "/3 fuels!";
            print(printMsg);

            // NEED TODO: Display properly in-game
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), printMsg);
        }
        if (showMsg3 == 1)
        {
            showMsg3 = 2;
            string printMsg = "Got " + numberOfFuels + "/3 fuels!";
            print(printMsg);

            // NEED TODO: Display properly in-game
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), printMsg);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        //print ("collided");
        if (col.gameObject.name == "ThirdPersonController")
        {
            if (fuel1 == true && fuel2 == true && fuel3 == true )
            {
                print("Done!");
                SceneManager.LoadScene("CharacterThirdPerson");
            }
            else {
                print("Need fuel!");
            }
        }
    }


}
           