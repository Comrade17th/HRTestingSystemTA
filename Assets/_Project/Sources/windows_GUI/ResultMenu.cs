using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResultMenu : Window
{
    [SerializeField] private Slider[] _sliders;
    [SerializeField] private Text[] _texts;
    [SerializeField] private ResultCalculatorAdzies _calculator;

    protected override void OnEnable()
    {
        base.OnEnable();
        
        int[] results = _calculator.GetResult();
        for (int i = 0; i < results.Length; i++)
        {
            _sliders[i].value = results[i];
            _texts[i].text = $"{results[i]}";
        }
    }
}
