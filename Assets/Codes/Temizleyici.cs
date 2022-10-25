using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temizleyici : MonoBehaviour
{
    public static int skor = 0;
    public TextMeshProUGUI skorYazisi;


    private void OnTriggerEnter2D(Collider2D temas)
    {
        float xPosition = Random.Range(-6.60f, 9.30f);
        float yPosition = 10f;

        if (temas.tag == "Platform")
        {
            //Destroy(temas.gameObject);
            skor += Random.Range(5,14);

            temas.transform.position = new Vector2(xPosition,transform.position.y+yPosition);
        }
    }

    void Update()
    {
        skorYazisi.text = "Skor: " + skor.ToString();
    }
}
