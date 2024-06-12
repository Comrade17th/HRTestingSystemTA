using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GerchikovQuest
{
    public string question;
    public int maxAnswersCount;
    public List<string> answerVariants;
    public List<bool> toggledVariants;
}
