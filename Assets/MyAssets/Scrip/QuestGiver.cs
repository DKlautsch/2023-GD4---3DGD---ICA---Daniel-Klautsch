using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    
    

    
    [SerializeField]
    private Quest[] quests;
    [SerializeField]
    private Collider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player)
        {

            


           player.gameObject.GetComponent<NavScrip>().onAnswerGiven.Invoke();
        }
    }


}
