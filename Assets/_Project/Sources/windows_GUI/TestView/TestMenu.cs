using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class TestMenu : Window
{
    [SerializeField] private Button _nextQuestion;
    [SerializeField] private Button _previousQuestion;
    [SerializeField] private Button _showResults;
    [SerializeField] private Question _question;

    public event Action ShowResultsButtonClicked; 

    private void Awake()
    {
        Assert.IsNotNull(_nextQuestion);
        Assert.IsNotNull(_previousQuestion);
        Assert.IsNotNull(_showResults);
        Assert.IsNotNull(_question);
    }
    
    private void OnEnable()
    {
        _nextQuestion.onClick.AddListener(_question.LoadNext);
        _previousQuestion.onClick.AddListener(_question.LoadPrevious);
        _showResults.onClick.AddListener(OnShowResultsButtonClicked);
    }

    private void OnDisable()
    {
        _nextQuestion.onClick.RemoveListener(_question.LoadNext);
        _previousQuestion.onClick.RemoveListener(_question.LoadPrevious);
        _showResults.onClick.RemoveListener(OnShowResultsButtonClicked);
    }

    private void OnShowResultsButtonClicked()
    {
        ShowResultsButtonClicked?.Invoke();
    }
}
