using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFUnctions : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject middlePlatform;
    public GameObject rightPlatform;

    public bool activePlat = false;
    public AudioSource platActiveFX;


    public void LeftPlat(){
        if(!activePlat){
            activePlat = true;
            platActiveFX.Play();
            leftPlatform.SetActive(true);
            StartCoroutine(LeftReset());
        }
    }
    public void MidPlat(){
        if(!activePlat){
            activePlat = true;
            platActiveFX.Play();
            middlePlatform.SetActive(true);
            StartCoroutine(MidReset());
        }
    }
    public void RightPlat(){
        if(!activePlat){
            activePlat = true;
            platActiveFX.Play();
            rightPlatform.SetActive(true);
            StartCoroutine(RughtReset());
        }
    }

    IEnumerator LeftReset(){
        yield return new WaitForSeconds(0.5f);
        leftPlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator MidReset(){
        yield return new WaitForSeconds(0.5f);
        middlePlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator RughtReset(){
        yield return new WaitForSeconds(0.5f);
        rightPlatform.SetActive(false);
        activePlat = false;
    }
}
