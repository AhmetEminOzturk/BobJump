using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform bobpozisyon,kamerapozisyon;
    void Update()
    {
        if (bobpozisyon.position.y > kamerapozisyon.position.y)
        {
            kamerapozisyon.position = new Vector3(kamerapozisyon.position.x, bobpozisyon.position.y, kamerapozisyon.position.z);
        }
    }


    public void QuitButton()
    {
        Application.Quit();
    }
}
