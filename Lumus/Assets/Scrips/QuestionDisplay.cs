using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionDisplay : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool pleaseUpdate = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    // Update is called once per frame
    void Update()
    {
        if (pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }
        
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TextMeshProUGUI>().text = newD;
    }
}
