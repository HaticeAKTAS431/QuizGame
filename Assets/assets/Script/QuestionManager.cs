using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    private int correctAnswerIndex;

    public GameObject correctPanel, wrongPanel;

    public Question[] questions;

    public Text questionText;
    public Text[] buttonTexts;

    private int currentQuestion = 0;





    public void Start()
    {
        SetQuestion(); 
    }
    private void SetQuestion()
    {
        questionText.text = questions[currentQuestion].questionText;
    
        for(int i=0; i< buttonTexts.Length; i++)
        {
            buttonTexts[i].text = questions[currentQuestion].answers[i];
        }

        {
            if (correctAnswerIndex == questions[currentQuestion].correctAnswerIndex)
            {
                currentQuestion++;

            }
            else 
        {
                currentQuestion++;
            }
        }

        
    }

    public void AnswerButton(int answerIndex)
    {
        if (answerIndex == correctAnswerIndex)
        {
            correctPanel.gameObject.SetActive(true);
        }
        else
        {
            wrongPanel.gameObject.SetActive(true);
        }
    }
    public void PanelButton(bool isTrue)
    {
        if (isTrue)
        {
            correctPanel.gameObject.SetActive(false);
            SetQuestion();
        }
        else
        {
            wrongPanel.gameObject.SetActive(false);
       
            SetQuestion();
                   }
    }


}
