﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject exitObjective;
    public static int theScore;
    public int goldNeeded;

    void Update()
    {
        if (theScore > 0 && theScore < goldNeeded)
        {
            scoreText.GetComponent<Text>().text = theScore + "/" + goldNeeded + " Gold";
        }
        else
        {
            scoreText.GetComponent<Text>().text = "";
        }

        
        if (theScore >= goldNeeded)
        { 
            exitObjective.SetActive(true);
            exitObjective.GetComponent<Objective>().title = "Exit found!";
            exitObjective.GetComponent<Objective>().description = "Gefeliciteerd";
            exitObjective.GetComponent<Objective>().UpdateObjective("Return to the carriage", "", "");
        }
    }
}