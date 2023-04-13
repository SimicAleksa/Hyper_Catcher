using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OCMManager : MonoBehaviour
{
    public GameObject gameTitle;
    public GameObject tapTpPlay;
    public GameObject belaPozadina;
    public GameObject globalScripts;
    public GameObject contdownText;
    public GameObject tapButton;
    public GameObject theRealCOnter;
    public GameObject finalScore;

    private void Start()
    {
        StartCoroutine(StartUpGame());
    }

    IEnumerator StartUpGame()
    {
        tapButton.SetActive(true);
        yield return new WaitForSeconds(1);
        gameTitle.SetActive(true);
        yield return new WaitForSeconds(2);
        tapTpPlay.SetActive(true);
    }

    public void TapToStart()
    {
        tapButton.SetActive(false);
        gameTitle.SetActive(false);
        tapTpPlay.SetActive(false);
        belaPozadina.SetActive(false);
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame()
    {
        finalScore.SetActive(false);
        yield return new WaitForSeconds(1);
        contdownText.SetActive(true);
        yield return new WaitForSeconds(1);
        theRealCOnter.GetComponent<TextMeshProUGUI>().text= "2";
        yield return new WaitForSeconds(1);
        theRealCOnter.GetComponent<TextMeshProUGUI>().text = "1";
        yield return new WaitForSeconds(1);
        contdownText.SetActive(false);
        theRealCOnter.GetComponent<TextMeshProUGUI>().text = "3";
        globalScripts.GetComponent<Timer>().enabled = true;
        globalScripts.GetComponent<OrbGenerate>().enabled = true;
        tapTpPlay.SetActive(false);
        
    }
}
