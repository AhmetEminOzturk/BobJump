using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float ziplamaguc;
    private Vector2 karakterHiz;
    private Rigidbody2D fizik;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        fizik = temas.collider.GetComponent<Rigidbody2D>();

        if (temas.relativeVelocity.y <= 0)
        {
            if (fizik != null)
            {
                karakterHiz = fizik.velocity;
                karakterHiz.y = ziplamaguc;
                fizik.velocity = karakterHiz;
               
            }
        }

        


    }




}
