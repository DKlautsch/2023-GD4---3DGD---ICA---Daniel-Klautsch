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

    public void rando()
    {
        this.transform.position = new Vector3(Random.Range(1.50f, 13.10f),1.16f, Random.Range(-13.00f, 13.00f));
    }


}
