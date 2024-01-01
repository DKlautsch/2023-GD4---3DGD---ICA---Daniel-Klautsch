using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private Collider player;
    public GameObject tutorial;
    public GameObject nextTutorial;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player)
        {

            player.GetComponent<NavScrip>().HasKey = true;
            this.gameObject.SetActive(false);
            if(tutorial!=null)
            {
                Destroy(tutorial.gameObject);
                nextTutorial.SetActive(true);
            }


        }
    }



}
