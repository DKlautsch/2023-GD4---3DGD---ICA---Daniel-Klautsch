using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public int answerId;

    public void CallHome()
    {
            
            this.transform.parent.transform.parent.GetComponent<QuestRecall>().CallQuester(answerId);
    }


}
