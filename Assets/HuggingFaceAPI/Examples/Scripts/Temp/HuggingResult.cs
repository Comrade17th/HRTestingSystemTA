using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hugging.API
{
public static class Face
{
    public static string RequestResult()
    {
        string[] array = { "Начальник отдела", "Руководитель отдела", "Директор", "Генеральный Директор", "Заместитель начальника отдела", "Инженер", "Главный инженер" };
        //Random random = new Random();
        
        int index = Random.Range(0, array.Length);
        return array[index];
    }
}
    
}

