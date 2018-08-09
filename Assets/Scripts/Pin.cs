using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {   
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag =="Rotator")
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed += 10f;
            //col.GetComponent<Rotator>().speed *= -1f;
            score.PinCount++;
            isPinned = true;

        }
        if (col.tag == "Rotator2")
        {
            transform.SetParent(col.transform);
            col.GetComponent<Rotator>().speed += 12f;
            //col.GetComponent<Rotator>().speed *= -1f;
            score.PinCount++;
            isPinned = true;

        }
        if (col.tag == "Rotator3")
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed += 15f;
            col.GetComponent<Rotator>().speed *= -1.1f;
            score.PinCount++;
            isPinned = true;

        }
        else if(col.tag=="Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}