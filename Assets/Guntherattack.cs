using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guntherattack : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;

    private float timer;
    private GameObject Player;

    void Start() 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() 
    {

        float distance = Vector2.Distance(transform.position, Player.transform.position);
        Debug.Log(distance);


        if (distance < 20) 
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

        
    }
    void shoot() 
    {
        Instantiate(bullet, bulletpos.position, Quaternion.identity);
    }
}
