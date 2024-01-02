using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndGame : MonoBehaviour
{

    [SerializeField]
    private GameObject Zeus;

    [SerializeField]
    private GameObject Poseidon;

    [SerializeField]
    private GameObject Hades;

    public int tickTock = 0;

    [SerializeField]
    private GameObject resScreen;



    public void checkEnd()
    {
        if(tickTock<30)
            return;

        string temp = "";

        bool ZeusHappy = Zeus.GetComponent<QuestGiver>().correctAnswers >= 7 ? true : false;
        bool PoseidonHappy = Poseidon.GetComponent<QuestGiver>().correctAnswers >= 7 ? true : false;
        bool HadesHappy = Hades.GetComponent<QuestGiver>().correctAnswers >= 7 ? true : false;

        if(ZeusHappy==false&&PoseidonHappy==false&&HadesHappy==false)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "Due to your poor amount of knowledge of  the gods, they have deemed humanity to be forsaken.\n";
            temp += "The gods rarely agree on anything, but they do agree that your performance was dissapointing.\n";
            temp += "Almost as if you didn't even really read the questions and just spam-clicked through...\n";
            temp += "\n";
            temp += "All the gods pack their stuff and leave.\n";
            temp += "And then Ancient Greece implodes.\n";
            temp += "The priestesses are really dissapointed with you.\n";
            temp += "Except for Athanasia, who kinda suspected you would fail everyone from the get go.\n";
            temp += "Good job, Player!\n";
        }
        if(ZeusHappy==true&&PoseidonHappy==false&&HadesHappy==false)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "Zeus likes you, and as Ambrosia reiterates to you, that counts for a lot.\n";
            temp += "Even if you can't go anywhere near a shore without having the waves actively try to pull you in.\n";
            temp += "...and Hades trying to orchestrate  your early departure.\n";
            temp += " You go on to live rather peacefully, and plainly the rest of your life.\n";
            temp += "Surely Zeus, Apomyiuses and Apemius, averter of Ills are all looking out for you.\n";
            temp += "\n";
            temp += "Good Job!\n";
        }
        if(ZeusHappy==false&&PoseidonHappy==true&&HadesHappy==false)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "Enraged by your lack of knowledge Zeus and Hades conspire to destroy you.\n";
            temp += "Ambrosia getting word of this warns you before it becomes too late.\n";
            temp += "With the help of Alkyone, you escape  to the sea.\n";
            temp += "You live out the rest of your days in Poseidon's domain.\n";
            temp += " You go on to become a famous Pirate, putting to use the famous Burning Mirros to sink other ships.\n";
            temp += "\n";
            temp += "Good Job!\n";
        }
        if(ZeusHappy==false&&PoseidonHappy==false&&HadesHappy==true)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "Old Habits die hard.\n";
            temp += "Zeus and Poseidon were so enraged with your lack of knowledge of them that they decided to kill humanity with a flood... again.\n";
            temp += "Luckily, Athenasia comes to your aid. Plouton Priests hold together.\n";
            temp += "Together you venture to the mouth of the Underworld, and head inside.\n";
            temp += "Closing the entrance behind you before the flood arrives and everyone except you and Athenasia die.\n";
            temp += "\n";
            temp += "Good... Job ?\n";
        }
        if(ZeusHappy==false&&PoseidonHappy==true&&HadesHappy==true)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "It's hard to keep everyone happy. But you managed to do just that.\n";
            temp += "Unfortunately pleasing the majorityy, means little when you dissapoint the king of all Gods.\n";
            temp += "In a fit of rage, Zeus turns you into a Wolf as which you are forced to live out the rest of your life.\n";
            temp += "Alkyone and Athenasia keep you company though, the latter of which occasionally jokes(?) that you'd make a good sacrifice.\n";
            temp += "And for what it's worth, Ambrosia was true to her word.\n";
            temp += "\n";
            temp += "Good Boy!\n";
        }
        if(ZeusHappy==true&&PoseidonHappy==false&&HadesHappy==true)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "You may have dissapointed Poseidon, but who cares about the sea? You are a land-lover.\n";
            temp += "Zeus keeps you well fed, and Hades sees to it, that you always live in comfortable amount of wealth.\n";
            temp += "Alkyone sometimes off handedly mentioned that Sailors have been struggling more and more with storms lately...\n";
            temp += "...and she urges you to seek forgiveness from Poseidon.\n";
            temp += "\n";
            temp += "But that sounds like a them problem.\n";
            temp += "Nice Job!\n";
        }
        if(ZeusHappy==true&&PoseidonHappy==true&&HadesHappy==false)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "You have done well to keep all of the important gods happy.\n";
            temp += "Most citizens agree that you did well, in averting ills for the town.\n";
            temp += "Besides it's not like Hades cares much about worship and all that.\n";
            temp += "You maintain good relations with Ambrosia and Alkyone, as the Temply of Hades stands abandoned.\n";
            temp += "The only thing that remian inside, is a shedded SnakeSkin and an air of bitter melancholy.\n";
            temp += "\n";
            temp += "You did your Job.\n";
        }
        if(ZeusHappy==true&&PoseidonHappy==true&&HadesHappy==true)
        {
            temp = "Congratulations!\n";
            temp += "Number of correct answers: \n";
            temp += "Zeus: "+Zeus.GetComponent<QuestGiver>().correctAnswers+"/10"+ " Poseidon:" + Poseidon.GetComponent<QuestGiver>().correctAnswers+ "/10" + "Hades: "+ Hades.GetComponent<QuestGiver>().correctAnswers+ "/10" + "\n";
            temp += "Hot damn! The gods love you!\n";
            temp += "Zeus enriches the towns fields, while Poseidon delivers your sailors and fishers with excellent fortune.\n";
            temp += "You aren't sure but it seems even Hades, is pulling things for the town's wealth to increase.\n";
            temp += "You and the priestesses, come together to see if you can combine their worship.\n";
            temp += "While hesitant at first, you manage to convince the priestesses and the gods, that they can work in harmony.\n";
            temp += "Long live Ancient Greece!\n";
            temp += "Good Job !\n";
        }

        resScreen.SetActive(true);
        resScreen.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Text>().text = temp;
        


    }



}
