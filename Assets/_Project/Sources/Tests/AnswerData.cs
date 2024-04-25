using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnswerData
{
    public List<string> Answers;
    public List<int> Values;

    public void InitValues()
    {
        Values = new List<int>() {1, 1, 1, 1};
    }

}
