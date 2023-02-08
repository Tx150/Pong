using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.name == "Ball")
        {
            string wallname = transform.name;
            gamemanager.Score(wallname);
            hit.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }

}

