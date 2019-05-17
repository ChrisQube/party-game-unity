using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    public GameObject doorGreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.GetComponent<SpriteRenderer>().material.color = Color.green;
        door.SetActive(false);
        doorGreen.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        door.SetActive(true);
        doorGreen.SetActive(false);
        button.GetComponent<SpriteRenderer>().material.color = new Color(1f, 165f/255f, 165f/255f);
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        door.SetActive(false);
    }
    private void OnTriggerExit(Collider Player)
    {
        door.SetActive(true);
    }
    */
}
