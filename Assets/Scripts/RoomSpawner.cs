using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openSide;

    //1 Need Botton door 
    //2 Need Top door
    //3 Need Left door
    //4 Need Right door

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
    void Start()
    {

        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("spawn",0.1f);
    }

    void Spawn()
    {

        if (spawned == false)
        {

            if (openSide == 1)
            {
                //Need Botton door
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
            }
            if (openSide == 2)
            {
                //Need Top door
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            if (openSide == 3)
            {
                //Need Left door
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            if (openSide == 4)
            {
                //Need Right door
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpanwPoint"))
        {

            Destroy(gameObject);
        }
    }
}
