using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionData : MonoBehaviour
{
    [SerializeField] public AnswerData[] _answerData;

    private AnswerData GetAnswerByIndex(int index)
    {
        return _answerData[index];
    }
}
