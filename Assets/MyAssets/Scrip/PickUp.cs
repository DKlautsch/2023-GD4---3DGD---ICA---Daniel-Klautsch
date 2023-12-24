using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private Collider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player)
        {

            player.GetComponent<NavScrip>().HasKey = true;

            this.gameObject.SetActive(false);



        }
    }



}
