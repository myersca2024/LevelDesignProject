using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootObject : MonoBehaviour
{
    public GameObject echo;
    public float speed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var mouseDir = mousePos - gameObject.transform.position;
            mouseDir.z = 0.0f;
            mouseDir = mouseDir.normalized;

            GameObject bullet = Instantiate(echo, this.transform.position, this.transform.rotation);
            bullet.transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(mouseDir * speed, ForceMode2D.Impulse);
        }
    }
}
