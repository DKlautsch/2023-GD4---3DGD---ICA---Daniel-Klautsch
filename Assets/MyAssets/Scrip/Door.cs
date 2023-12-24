using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Collider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player&&player.GetComponent<NavScrip>().HasKey)
        {
            player.GetComponent<NavScrip>().HasKey = false;
            
            this.gameObject.SetActive(false);



        }

    }



}
