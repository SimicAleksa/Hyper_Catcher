using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public GameObject timeDisplay;
    public bool countingDOwn = false;
    public static int currentSecconds = 30;
    public bool isZero = false;
    public GameObject globalScripts;
    public GameObject whiteBG;
    public GameObject finalScore;
    public GameObject tapToPlay;
    public GameObject button;

    void Update()
    {
        if(!countingDOwn && !isZero)
        {
            countingDOwn = true;
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSecconds -= 1;
        timeDisplay.GetComponent<TextMeshProUGUI>().text = currentSecconds.ToString();
        if (currentSecconds == 0)
        {
            isZero = true;
            globalScripts.GetComponent<OrbGenerate>().enabled = false;
            globalScripts.GetComponent<Timer>().enabled = false;
            yield return new WaitForSeconds(1);
            whiteBG.SetActive(true);
            finalScore.GetComponent<TextMeshProUGUI>().text = "Final score \n"+ScoreUpdater.orbScore.ToString();
            finalScore.SetActive(true);
            StartCoroutine(GameOver());
        }
        countingDOwn = false;
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1.2f);
        tapToPlay.SetActive(true);
        button.SetActive(true);
        timeDisplay.GetComponent<TextMeshProUGUI>().text = "30";
        currentSecconds = 30;
        isZero = false;
        countingDOwn = false;
        ScoreUpdater.orbScore = 0;
    }
}
