using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMenu : Window
{
    [SerializeField] private Button _nextQuestion;
    [SerializeField] private Button _previousQuestion;
    [SerializeField] private Question _question;

    private void OnEnable()
    {
        _nextQuestion.onClick.AddListener(_question.LoadNext);
        _previousQuestion.onClick.AddListener(_question.LoadPrevious);
    }

    private void OnDisable()
    {
        _nextQuestion.onClick.RemoveListener(_question.LoadNext);
        _previousQuestion.onClick.RemoveListener(_question.LoadPrevious);
    }
}
