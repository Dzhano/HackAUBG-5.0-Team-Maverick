using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour
{
    public GameObject answerABackBlue;  //Blue is waiting
    public GameObject answerABackGreen; //Green is correct
    public GameObject answerABackRed;   //Red is wrong

    public GameObject answerBBackBlue;  //Blue is waiting
    public GameObject answerBBackGreen; //Green is correct
    public GameObject answerBBackRed;   //Red is wrong

    public GameObject answerCBackBlue;  //Blue is waiting
    public GameObject answerCBackGreen; //Green is correct
    public GameObject answerCBackRed;   //Red is wrong

    public GameObject answerDBackBlue;  //Blue is waiting
    public GameObject answerDBackGreen; //Green is correct
    public GameObject answerDBackRed;   //Red is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    
    public AudioSource correctFX;
    public AudioSource wrongFX;

    // public GameObject currentScore;
    // public int scoreValue;

    // public int bestScore;
    // public GameObject bestDisplay;
    public GameObject visual001;



    // void Start()
    // {
    //     bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
    //     bestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + bestScore;
    // }

    // void Update()
    // {
    //     currentScore.GetComponent<TextMeshProUGUI>().text = "SCORE: " + scoreValue;
    // }
    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerABackGreen.SetActive(true);
            answerABackBlue.SetActive(false);
            correctFX.Play();
            // scoreValue += 5;
            Stone.steps = 1;
            // SceneManager.UnloadScene(0);
        }
        else
        {
            answerABackRed.SetActive(true);
            answerABackBlue.SetActive(false);
            wrongFX.Play();
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBBackGreen.SetActive(true);
            answerBBackBlue.SetActive(false);
            correctFX.Play();
            // scoreValue += 5;
            Stone.steps = 1;
            // SceneManager.UnloadScene(0);
        }
        else
        {
            answerBBackRed.SetActive(true);
            answerBBackBlue.SetActive(false);
            wrongFX.Play();
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCBackGreen.SetActive(true);
            answerCBackBlue.SetActive(false);
            correctFX.Play();
            // scoreValue += 5;
            Stone.steps = 1;
            // SceneManager.UnloadScene(0);
        }
        else
        {
            answerCBackRed.SetActive(true);
            answerCBackBlue.SetActive(false);
            wrongFX.Play();
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDBackGreen.SetActive(true);
            answerDBackBlue.SetActive(false);
            correctFX.Play();
            // scoreValue += 5;
            Stone.steps = 1;
            // SceneManager.UnloadScene(0);
        }
        else
        {
            answerDBackRed.SetActive(true);
            answerDBackBlue.SetActive(false);
            wrongFX.Play();
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    
    IEnumerator NextQuestion()
    {
        // if(bestScore < scoreValue)
        // {
        //     PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
        //     bestScore = scoreValue;
        //     bestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + scoreValue;
        // }

        yield return new WaitForSeconds(1);
        
        visual001.SetActive(false);
        answerABackGreen.SetActive(false);
        answerBBackGreen.SetActive(false);
        answerCBackGreen.SetActive(false);
        answerDBackGreen.SetActive(false);

        answerABackRed.SetActive(false);
        answerBBackRed.SetActive(false);
        answerCBackRed.SetActive(false);
        answerDBackRed.SetActive(false);

        answerABackBlue.SetActive(false);
        answerBBackBlue.SetActive(false);
        answerCBackBlue.SetActive(false);
        answerDBackBlue.SetActive(false);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerate.displayingQuestion = false;
        
        SceneManager.UnloadScene(0);
    }
}
