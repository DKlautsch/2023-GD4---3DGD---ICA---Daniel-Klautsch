using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class QuestGiver : MonoBehaviour
{
    
    

    
    [SerializeField]
    private List<Quest> quests;
    [SerializeField]
    private Collider player;

    [Header("UI")]
    [SerializeField]
    private Canvas questionUI;
    [SerializeField]
    private Text dialogue;
    [SerializeField]
    private Text[] answers;

    private void OnTriggerEnter(Collider other)
    {
        if(other==player)
        {

            dialogue.text = quests[0].question;

            for(int i = 0; i<3;i++)
            {
                answers[i].text = quests[0].answers[i].answer;
            }


            questionUI.gameObject.SetActive(true);





           }
    }

    public void QuestAnswered(int answer)
    {
        dialogue.text = quests[0].answers[answer].feedback;

        player.gameObject.GetComponent<NavScrip>().onAnswerGiven.Invoke();
    }


}
