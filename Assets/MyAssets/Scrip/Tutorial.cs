using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject nextTutorial;

    [SerializeField]
    private Collider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player)
        {

            if(tutorial!=null && tutorial.activeSelf == true )
                {
                      Destroy(tutorial.gameObject);
                      if(nextTutorial!=null)
                        nextTutorial.SetActive(true);
                }

        }
    }
}
