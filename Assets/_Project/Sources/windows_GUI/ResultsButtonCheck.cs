using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ResultsButtonCheck : MonoBehaviour
{
    [SerializeField] private UserDatabase _userDatabase;

    private void Awake()
    {
        Assert.IsNotNull(_userDatabase);
    }

    private void Start()
    {
        CheckRole();
    }

    private void OnEnable()
    {
        CheckRole();
    }

    private void CheckRole()
    {
        if (_userDatabase.AuthorizedUser.role == "Admin")
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
