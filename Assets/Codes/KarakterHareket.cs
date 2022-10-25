using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterHareket : MonoBehaviour
{

    public float harekethiz;
    public Rigidbody2D Bob;
    private float hareketinput;
    public TextMeshProUGUI bitisYazisi;
    public GameObject panel;


    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "BitisCubuk")
        {
            Time.timeScale = 0;
            panel.SetActive(true);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    void Update()
    {
        hareketinput = Input.GetAxis("Horizontal");
        Bob.velocity = new Vector2(hareketinput * harekethiz, Bob.velocity.y);
        bitisYazisi.text = "Tebrikler \n" + "Skorunuz:" + Temizleyici.skor.ToString();
    }

    public void yenidenbaslat()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Temizleyici.skor = 0;
        panel.SetActive(false);
    }
}
