using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class QuestGiver : MonoBehaviour
{
    
    [SerializeField]
    private int correctAnswers = 0;
    
    [SerializeField]
    private List<Quest> quests;
    [SerializeField]
    private Collider player;

    private int tracker;


    [SerializeField]
    private GameObject tutorial;

    [SerializeField]
    private GameObject key;

    [Header("UI")]
    [SerializeField]
    private Canvas questionUI;
    [SerializeField]
    private Text dialogue;
    [SerializeField]
    private Text[] answers;

    [SerializeField]
    private Text score;

    private string perfReview;

    private void OnTriggerEnter(Collider other)
    {
        if(tutorial!=null)
            key.gameObject.GetComponent<Tutorial>().tutorial = tutorial;

        if(other==player)
        {
            if(quests.Count != 0)
            {
                dialogue.text = quests[0].question;
                
                int t = Random.Range(0,2);
                for(int i = 0; i<3;i++)
                {
                    if(t==2)
                        t=0;
                    else
                        t++;


                    answers[i].text = quests[0].answers[t].answer;
                    answers[i].transform.parent.GetComponent<Answer>().answerId = t;




                }
                questionUI.gameObject.SetActive(true);
                questionUI.gameObject.GetComponent<QuestRecall>().LastQuester = this;
                questionUI.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {   
                perfReview = "The Gods judges your performance and have found... \n";
                perfReview += "   " + correctAnswers + "/10   \n";
                if(correctAnswers<7) 
                    perfReview += "   you to be lacking... Watch yourself.\n";
                else
                    perfReview += "   you to be worthy... You have there blessing.\n";
                perfReview += "      Carry on to seek the other gods knowledge and blessings.";

                dialogue.text = perfReview;
                questionUI.gameObject.SetActive(true);
                questionUI.gameObject.transform.GetChild(3).gameObject.SetActive(true);
                
            }
        }
    }

    public void QuestAnswered(int answer)
    {

        Debug.Log(answer);

        if(quests[0].answers[answer].acceptedAnswer==true)
        correctAnswers++;

        dialogue.text = quests[0].answers[answer].feedback;
        quests.Remove(quests[0]);
        tracker++;
        score.text = tracker +"/10";
    }

    public void Finish()
    {
        player.gameObject.GetComponent<NavScrip>().onAnswerGiven.Invoke();
        
    }



}
