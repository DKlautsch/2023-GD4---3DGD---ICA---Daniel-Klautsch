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
            this.gameObject.GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled= false;
            this.gameObject.transform.eulerAngles = new Vector3(0.0f, 90.0f, 0.0f);
            this.gameObject.transform.GetChild(0).GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled= false;

        }

    }

    public void Reset()
    {
        this.gameObject.GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled= true;
            this.gameObject.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            this.gameObject.transform.GetChild(0).GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled= true;

    }



}
