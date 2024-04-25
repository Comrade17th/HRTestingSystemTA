using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] private QuestionData _questionDataAdzies;
    [SerializeField] private Text _questionText;
    [SerializeField] private Answer[] _answers;

    private int _current = 0;
    private int TotalQuestions => _questionDataAdzies._answerData.Length;

    private void Awake()
    {
        Assert.IsNotNull(_questionDataAdzies);
        
        InitQuestions();
    }

    private void Start()
    {
        LoadQuestion(_current);
    }

    public void LoadNext()
    {
        if (_current + 1 < TotalQuestions)
        {
            SaveCurrentAnswerData();
            _current++;
            LoadQuestion(_current);
        }
        else
        {
            Debug.Log($"It's the last question");
        }
    }
    
    public void LoadPrevious()
    {
        if (_current - 1 >= 0)
        {
            SaveCurrentAnswerData();
            _current--;
            LoadQuestion(_current);
            
        }
        else
        {
            Debug.Log($"It's the first question");
        }
    }

    private void InitQuestions()
    {
        foreach (var answerData in _questionDataAdzies._answerData)
        {
            answerData.InitValues();
        }
    }

    private void LoadQuestion(int index)
    {
        if (index < 0 ||
            index >= _questionDataAdzies._answerData.Length)
        {
            Debug.Log($"Requested answer out of range");
        }
        else
        {
            AnswerData data = _questionDataAdzies._answerData[index];

            for (int i = 0; i < data.Answers.Count; i++)
            {
                _answers[i].SetText(data.Answers[i]);
                _answers[i].SetValue(data.Values[i]);
            }

            _current = index;
        }
    }

    private void SaveCurrentAnswerData()
    {
        AnswerData data = _questionDataAdzies._answerData[_current];
        data.Values = new List<int>();
        
        for (int i = 0; i < _answers.Length; i++)
        {
            data.Values.Add(_answers[i].GetValue());
        }
        
        _questionDataAdzies._answerData[_current] = data;
    }
}
