using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.TextCore.Text;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int orbScore;

    void Update()
    {
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "SCORE: "+ orbScore;
    }
}
