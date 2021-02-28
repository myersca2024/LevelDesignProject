using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoWall : MonoBehaviour
{
    public GameObject oppositeDoor;
    public string direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Echo")
        {
            GameObject parent = this.transform.parent.gameObject;
            DoorManager manager = parent.GetComponent<DoorManager>();

            switch (direction)
            {
                case "north":
                    if (manager.currentNum == 5)
                    {
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        Vector3 diff = oppositeDoor.transform.position - this.transform.position;
                        other.gameObject.transform.position += (diff * 0.9f);
                    }
                    break;
                case "south":
                    if (manager.currentNum == 3)
                    {
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        Vector3 diff = oppositeDoor.transform.position - this.transform.position;
                        other.gameObject.transform.position += (diff * 0.9f);
                    }
                    break;
                case "east":
                    if (manager.currentNum == 2 || manager.currentNum == 4)
                    {
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        Vector3 diff = oppositeDoor.transform.position - this.transform.position;
                        other.gameObject.transform.position += (diff * 0.9f);
                    }
                    break;
                case "west":
                    if (manager.currentNum == 1)
                    {
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        Vector3 diff = oppositeDoor.transform.position - this.transform.position;
                        other.gameObject.transform.position += (diff * 0.9f);
                    }
                    break;
            }
        }
    }
}
