using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCalculatorAdzies : MonoBehaviour
{
    [SerializeField] private QuestionData _questionDataAdzies;

    private int groupCount = 10;
    private int groupSize = 4;
    // PAEI => 0123
    private int[,] parametersPAEI = new int[,]
    {
        {0, 3, 2, 1},
        {2, 1, 0, 3},
        {1, 0, 3, 2},
        {1, 0, 3, 2},
        {1, 0, 3, 2},
        {1, 0, 3, 2},
        {0, 2, 1, 3},
        {3, 1, 2, 0},
        {2, 1, 0, 3},
        {2, 3, 0, 1}
    };
    
    private int[] _sumPAEI = new int[] {0, 0, 0, 0};
    
    public int[] GetResult()
    {
        CalculateSum();
        Debug.Log(_sumPAEI);
        return _sumPAEI;
    }

    private void CalculateSum()
    {
        int[] sumPAEI = new int[] { 0, 0, 0, 0 };
        
        for (int i = 0; i < groupCount; i++)
        {
            AnswerData data = _questionDataAdzies._answerData[i];
            List<int> values = data.Values;
            
            for (int j = 0; j < groupSize; j++)
            {
                int indexPAEI = parametersPAEI[i, j];
                sumPAEI[indexPAEI] += values[j];
            }
        }

        _sumPAEI = sumPAEI;
    }
}
