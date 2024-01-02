using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestRecall : MonoBehaviour
{

    public QuestGiver LastQuester;

    // Start is called before the first frame update
    public void CallQuester(int answer)
    {
        LastQuester.QuestAnswered(answer);

    }


}
