using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "DQT/New Quest", order = 1)]
public class Quest : ScriptableObject
{
    [SerializeField]
    private string description;

    [SerializeField]
    private string question;

    [SerializeField]
    private AnswerFeedback[] answers;


    [System.Serializable]
    private class AnswerFeedback
    {
        [SerializeField]
        private bool acceptedAnswer = false;

        [SerializeField]
        private string answer;

        [SerializeField]
        private string feedback;
    }

    


}
