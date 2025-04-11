using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;

    float timerValue;

    void Update()
    {
        UpdateTimer();       
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToCompleteQuestion;
            }
        }
        else
        {
            isAnsweringQuestion = true;
            timerValue = timeToShowCorrectAnswer;
        }

        Debug.Log(timerValue);
    }
}
