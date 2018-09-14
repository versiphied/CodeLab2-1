using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words : MonoBehaviour {

    public Text Person1;
    public Text Person2;
    public Text Name1;
    public Text Name2;
    public int _int = 1;
    public GameObject ChoiceOne;
    public GameObject ChoiceTwo;
    public GameObject button;

    public void talking()
    {
        _int = _int + 1;

        if (_int == 2)
        {
            Person1.text = "I had a bean burrito and now I have the runs";
            Name1.text = "Regis";

            Person2.text = "";
            Name2.text = "";
        }

        else if (_int == 4)
        {
            Person1.text = "Don't tell me what to do, Kathy";
            Name1.text = "Regis";

            Person2.text = "";
            Name2.text = "";
        }
        else if (_int == 6)
        {
            Person1.text = "You're not even my real mom";
            Name1.text = "Regis";

            Person2.text = "";
            Name2.text = "";
        }
        else if (_int == 3)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "Don't use too many whipes. They make you dry";
            Name2.text = "Kathy";
        }
        else if (_int == 5)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "And you better wash your hands after";
            Name2.text = "Kathy";
        }
        else if (_int == 7)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "Are you ready for the show today?";
            Name2.text = "Kathy";
            button.SetActive(false);
            ChoiceOne.SetActive(true);
            ChoiceTwo.SetActive(true);
        }
        else if (_int == 100)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "Well hurry up! Don't make me wait";
            Name2.text = "Kathy";
            button.SetActive(true);
            _int = 119;
        }
        else if (_int == 101)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "Great! I'm so proud of you";
            Name2.text = "Kathy";
            button.SetActive(true);
            _int = 119;
        
        }
        else if (_int == 120)
        {
            Person1.text = "";
            Name1.text = "";

            Person2.text = "Time to start the show! To be continued";
            Name2.text = "Both";
            
            _int = 119;
        }
    }

    public void One()
    {
        Person1.text = "Yes";
        Name1.text = "Regis";
        Person2.text = "";
        Name2.text = "";
        _int = 100;
        ChoiceOne.SetActive(false);
        ChoiceTwo.SetActive(false);
        button.SetActive(true);
    }

    public void Two()
    {
        Person1.text = "No";
        Name1.text = "Regis";
        Person2.text = "";
        Name2.text = "";
        _int = 100;
        ChoiceOne.SetActive(false);
        ChoiceTwo.SetActive(false);
        button.SetActive(true);
    }
}
