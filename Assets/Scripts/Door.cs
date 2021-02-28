using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject oppositeDoor;
    public string direction;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 diff = oppositeDoor.transform.position - this.transform.position;
            other.gameObject.transform.position += (diff * 0.9f);
            GameObject parent = this.transform.parent.gameObject;
            DoorManager manager = parent.GetComponent<DoorManager>();

            switch(direction)
            {
                case "north":
                    if (manager.currentNum == 5)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                    else
                    {
                        manager.currentNum = 1;
                    }
                    break;
                case "south":
                    if (manager.currentNum == 3)
                    {
                        manager.currentNum++;
                    }
                    else if (manager.currentNum == 1)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }
                    else
                    {
                        manager.currentNum = 1;
                    }
                    break;
                case "east":
                    if (manager.currentNum == 2 || manager.currentNum == 4)
                    {
                        manager.currentNum++;
                    }
                    else
                    {
                        manager.currentNum = 1;
                    }
                    break;
                case "west":
                    if (manager.currentNum == 1)
                    {
                        manager.currentNum++;
                    }
                    else
                    {
                        manager.currentNum = 1;
                    }
                    break;
            }
        }
        if (other.gameObject.tag == "Echo")
        {
            Destroy(other.gameObject);
        }
    }
}
