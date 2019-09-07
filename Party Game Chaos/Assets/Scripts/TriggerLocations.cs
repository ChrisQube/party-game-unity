using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerLocations : MonoBehaviour
{
    public string playerName;

    TextMesh hoverTextComponent;
    bool newLocation = true;

    RectTransform bufferBarComponent;
    bool locationFullyBuffered = false;
    bool locationBufferOn = false;

    string collisionName1 = "";
    string collisionName2 = "";

    float xScale = 0;
    public float loadSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        hoverTextComponent = GetComponentInChildren<TextMesh>();
        bufferBarComponent = GetComponentInChildren<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (locationBufferOn && !locationFullyBuffered)
        {
            //Animation of locationBuffer
            //Timer
            if (xScale < 35)
            {
                xScale += loadSpeed;
                bufferBarComponent.localScale = new Vector3(xScale, bufferBarComponent.localScale.y);
            }
            else
            {
                locationFullyBuffered = true;
                locationBufferOn = false;

                locationBufferReset();
                
                if (newLocation)
                {
                    hoverTextComponent.text = collisionName1;
                    newLocation = false;
                }
                else
                {
                    hoverTextComponent.text = "";
                    newLocation = true;
                }

                //Check Quest/Task completion


                //Remember to reset locationName1 & 2 after quest completion/failure
                collisionName1 = "";
                collisionName2 = "";

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Location")
        {
            locationBufferOn = true;

            if (newLocation)
                collisionName1 = collision.name;
            else
                collisionName2 = collision.name;
        }
        else if (collision.tag == "Player Aura")
        {
            if (!newLocation)
            {
                collisionName2 = collision.name;

                locationBufferOn = true;

                Debug.Log("collided with player");
            }

        }

        //Check quest correct here.

        /* REMOVED
        //checks new location then updates HoverText above the specific player
        if (collision.tag == "Location" && newLocation)
        {
            locationBufferOn = true;

            if (locationFullyBuffered)
            {
                locationFullyBuffered = false;
                hoverTextComponent.text = collision.name; //this may need to be moved to a function with a timer
                newLocation = false; //this may need to be moved to a function with a timer
            }
        }
        //checks player on 2nd location then updates HoverText above the specific player
        else if (collision.tag == "Location" && !newLocation)
        {
            locationBufferOn = true;

            if (locationFullyBuffered)
            {
                locationFullyBuffered = false;
                hoverTextComponent.text = ""; //this may need to be moved to a function with a timer
                newLocation = true; //this may need to be moved to a function with a timer
            }
        }
        *///collapsed old code
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        locationBufferOn = false;
        locationFullyBuffered = false;
        locationBufferReset();
    }

    private void locationBufferReset()
    {
        xScale = 0;
        bufferBarComponent.localScale = new Vector3(xScale, bufferBarComponent.localScale.y);
    }

}
