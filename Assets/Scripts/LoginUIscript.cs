using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginUIscript : MonoBehaviour
{
    public Button loginButton;
    public InputField nameField;
    public InputField passwordField;

    public List<Tuple<string, string>> mockDB;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(loginClick);
        mockDB = new List<Tuple<string, string>> { new Tuple<string, string>("Johan5", "HuisMus12"), new Tuple<string, string>("JelleB", "WachtwoorD9") };
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool namePasswordMatch(string name, string password, List<Tuple<string, string>> database)
    {
        if (database == null || name == null || password == null)
        {
            return false;
        }
        foreach (var account in database)
        {
            if (account.Item1.ToLower() == name.ToLower())
            {
                if (account.Item2 == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return false;
    }

    void loginClick()
    {
        string name = nameField.GetComponentInChildren<Text>().text;
        string password = passwordField.GetComponentInChildren<Text>().text;
            
        if (namePasswordMatch(name,password,mockDB))
        {
            SceneManager.LoadScene("Overzicht");
        }
        else
        {
            //display a warning
        }
    }
}
