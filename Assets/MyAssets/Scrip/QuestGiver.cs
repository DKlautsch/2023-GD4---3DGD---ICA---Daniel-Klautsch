using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class QuestGiver : MonoBehaviour
{
    
    public int correctAnswers = 0;
    
    [SerializeField]
    private List<Quest> quests;
    [SerializeField]
    private Collider player;

    [SerializeField]
    private EndGame clock;        

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
        //Just checking if we already done all the turorial stuff
        if(tutorial!=null)
            key.gameObject.GetComponent<Tutorial>().tutorial = tutorial;

        if(other==player)
        {
            //Turn of player movement
            player.gameObject.GetComponent<NavScrip>().enabled = false;

            player.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(player.gameObject.transform.position);

            if(quests.Count != 0)
            {
                // Display stuff
                dialogue.text = quests[0].question;
                Random.State stateBeforeStep3 = Random.state;
                int t = Random.Range(0,2);
                for(int i = 0; i<3;i++)
                {
                    //Bit of a Random Rotation

                    if(t==2)
                        t=0;
                    else
                        t++;

                    // Random answers are put into random places

                    answers[i].text = quests[0].answers[t].answer;
                    answers[i].transform.parent.GetComponent<Answer>().answerId = t;




                }
                //Turnn on interface, adn leave our CalllingCard with QuestRecall
                questionUI.gameObject.SetActive(true);
                questionUI.gameObject.GetComponent<QuestRecall>().LastQuester = this;
                questionUI.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {   
                //Check if the game is over.
                clock.checkEnd();

                //Bit of feedbac as to how many questions they got right in total
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
        //Check if the answer was right and give back feedback
        if(quests[0].answers[answer].acceptedAnswer==true)
        correctAnswers++;

        dialogue.text = quests[0].answers[answer].feedback;

        //Clean up and set the trackers correctly
        quests.Remove(quests[0]);
        tracker++;
        clock.tickTock++;
        score.text = tracker +"/10";
    }

    public void Finish()
    {
        //Let the player know we are done, and he may carry on

        player.gameObject.GetComponent<NavScrip>().enabled = true;
        player.gameObject.GetComponent<NavScrip>().onAnswerGiven.Invoke();
        
    }



}
