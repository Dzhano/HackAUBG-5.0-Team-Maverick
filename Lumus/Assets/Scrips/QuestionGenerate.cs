using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 6);
            if (questionNumber == 1) 
            {
                
                QuestionDisplay.newQuestion = "How much wood could a would chuck chuck if a wood chuck could chuck wood?";
                QuestionDisplay.newA = "A. Lots and lots";
                QuestionDisplay.newB = "B. None";
                QuestionDisplay.newC = "C. Hardly any";
                QuestionDisplay.newD = "D. Six";
                actualAnswer = "A";
            }

            else if (questionNumber == 2) 
            {
                QuestionDisplay.newQuestion = "Who is the brother of Luigi?";
                QuestionDisplay.newA = "A. Toad";
                QuestionDisplay.newB = "B. DK";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                actualAnswer = "C";
            }

            else if (questionNumber == 3) 
            {
                QuestionDisplay.newQuestion = "Where is Japan?";
                QuestionDisplay.newA = "A. Africa";
                QuestionDisplay.newB = "B. Asia";
                QuestionDisplay.newC = "C. Europe";
                QuestionDisplay.newD = "D. America";
                actualAnswer = "B";
            }

            else if (questionNumber == 4) 
            {
                QuestionDisplay.newQuestion = "How old is the world";
                QuestionDisplay.newA = "A. Today";
                QuestionDisplay.newB = "B. Like 2";
                QuestionDisplay.newC = "C. 10 years";
                QuestionDisplay.newD = "D. Billions of years";
                actualAnswer = "D";
            }

            else if (questionNumber == 5) 
            {
                QuestionDisplay.newQuestion = "Which video game series would you see this?";
                QuestionDisplay.newA = "A. Halo";
                QuestionDisplay.newB = "B. Dark Souls";
                QuestionDisplay.newC = "C. Need for Speed";
                QuestionDisplay.newD = "D. Mario";
                visual001.SetActive(true);
                actualAnswer = "D";
            }

            // all questions above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
