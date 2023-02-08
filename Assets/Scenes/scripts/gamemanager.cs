using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static int playerscore1 = 0;
    public static int playerscore2 = 0;

    [SerializeField]
    private int winningScore;

    public GUISkin layout;

    private GameObject theball;



    // Start is called before the first frame update
    void Start()
    {
        theball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {




    }

    public static void Score(string wallID)
    {
        if (wallID == "Right Wall")
        {
            playerscore1++;
        }
        else
        {
            playerscore2++;
        }
    }


    private void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + playerscore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + playerscore2);
        
       if(GUI.Button(new Rect(Screen.width / 2 -60, 35, 120, 53), "Restart"))
        {
            playerscore1 = 0;
            playerscore2 = 0;
            theball.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

       if(playerscore1 == winningScore)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS!");
            theball.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);

        }
       else if (playerscore2 == winningScore)
           {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS!");
            theball.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }

}
