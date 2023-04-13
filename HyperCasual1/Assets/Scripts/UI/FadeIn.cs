using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{

    public GameObject gameTitle;
    void Update()
    {
        if(gameTitle.GetComponent<CanvasGroup>().alpha<1)
            gameTitle.GetComponent<CanvasGroup>().alpha += Time.deltaTime;
    }
}
