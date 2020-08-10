using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;      
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight){
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col){
        // 'col' holds the collision info, if ball collided with a racket:
        // col.gameObject is the racket
        // col.transform.position is the racket's position
        // col.collider is the racket's collider

        if(col.gameObject.name == "RacketLeft"){
            float y = hitFactor(
                transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1,y).normalized; // Calculate direction, make length=1 via .normalized
            GetComponent<Rigidbody2D>().velocity = dir * speed;        
        }
        if(col.gameObject.name == "RacketRight"){
            float y = hitFactor(
                transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1,y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;        
        }
    }
}
