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

    string locationName1 = "";
    string locationName2 = "";

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
                    hoverTextComponent.text = locationName1;
                    newLocation = false;
                }
                else
                {
                    hoverTextComponent.text = "";
                    newLocation = true;
                }

                //Check Quest/Task completion


                //Remember to reset locationName1 & 2 after quest completion/failure
                locationName1 = "";
                locationName2 = "";

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Location")
        {
            locationBufferOn = true;

            if (newLocation)
                locationName1 = collision.name;
            else
                locationName2 = collision.name;
        }

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
