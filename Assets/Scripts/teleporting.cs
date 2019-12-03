using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleporting : MonoBehaviour
{
    public Transform teleportTarget; //new spot
    public GameObject thePlayer; //the object that is moving
    public Text text;

    private string id;

    public void move()//collision
    {
        id = teleportTarget.name;
        Debug.Log(id);
        text.text = "Room" + id;
        thePlayer.transform.position = teleportTarget.transform.position; //translate (equate the location to new location)
    }

    private void Start()
    {
        
        
    }

    private void Update()
    {
        
        /*
        if (thePlayer.transform.position.x == 0 && thePlayer.transform.position.y == 0 && thePlayer.transform.position.z == 0)
        {
            text.text = "Room1";
        }
        else if (thePlayer.transform.position.x > 8 && transform.position.z < 0)
        {
            text.text = "Room2";
        }
        else if (thePlayer.transform.position.x > 1 && thePlayer.transform.position.y > 0 && thePlayer.transform.position.z > 7)
        {
            text.text = "Room3";
        }
        else if (thePlayer.transform.position.x < 0 && thePlayer.transform.position.z < 0)
        {
            text.text = "Room4";
        }
        */
    }
}