using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "DQT/New Quest", order = 1)]
public class Quest : ScriptableObject
{
   

    public string question;

    public AnswerFeedback[] answers;


    [System.Serializable]
    public class AnswerFeedback
    {
        public bool acceptedAnswer = false;

        public string answer;

        public string feedback;
    }

    


}
