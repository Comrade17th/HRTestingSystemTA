using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class AnswerDataInitializer
{
    private static int groups = 10;
    private static int groupSize = 4;
    private static string text = $"Вовлеченный\n" +
                                 $"Отзывчивый\n" +
                                 $"Яркий\n" +
                                 $"Сомневающийся\n" +
                                 
                                 $"Абстрактный\n" +
                                 $"Наблюдающий\n" +
                                 $"Активный\n" +
                                 $"Взаимодействующий\n" +
                                 
                                 $"Анализирующий\n" +
                                 $"Прямой\n" +
                                 $"Чувствующий\n" +
                                 $"Харизматичный\n" +
                                 
                                 $"Размышляющий\n" +
                                 $"Прагматичный\n" +
                                 $"Душевный\n" +
                                 $"Ориентированный на будущее\n" +
                                 
                                 $"Созерцающий\n" +
                                 $"Делающий\n" +
                                 $"Сопереживающий\n" +
                                 $"Думающий\n" +
                                 
                                 $"Наблюдающий\n" +
                                 $"Побеждающий\n" +
                                 $"Стремящийся_договориться\n" +
                                 $"Системный\n" +
                                 
                                 $"Готовый_взять_ответсвенность\n" +
                                 $"Идущий_на_риск\n" +
                                 $"Оценивающий\n" +
                                 $"Благожелательный\n" +
                                 
                                 $"Осведомленный\n" +
                                 $"Сдержанный\n" +
                                 $"Генерирующий_идеи\n" +
                                 $"Рациональный\n" +
                                 
                                 $"Задающий_вопросы\n" +
                                 $"Логичный\n" +
                                 $"Эффективный\n" +
                                 $"Интуитивный\n" +
                                 
                                 $"Яркий_выделяющийся\n" +
                                 $"Приятный\n" +
                                 $"Деловой_серьезный\n" +
                                 $"Аккуратный_точный";

    //private static AnswerData[] _answersData = { new AnswerData("")};

    public static AnswerData[] GetAnswers()
    {
        string[] answers = SplitByRow(text);
        AnswerData[] answersData = new AnswerData[groups];

        for (int i = 0; i < answers.Length; i++)
        {
            string[] group = new string[groupSize];

            for (int j = 0; i < groupSize; j++)
            {
                //group[j]
            }
        }

        return answersData;
    }
    
    private static string[] SplitByRow(string answersByRow)
    {
        char separator = '\n';
        string[] rows = answersByRow.Split(separator);
        return rows;
    }
    
    private static string[] SplitBySpace(string answersBySpace)
    {
        char separator = ' ';
        string[] rows = answersBySpace.Split(separator);
        return rows;
    }

    private static string ReplaceLines(string text)
    {
        char oldChar = '_';
        char newChar = ' ';
        StringBuilder sb = new StringBuilder(text);

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == oldChar)
                sb[i] = newChar;
        }
            
        return sb.ToString();
    }
    
}
