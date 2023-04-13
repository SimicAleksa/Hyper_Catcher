using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatchFX;
    public GameObject typeOfPlac;

    public void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "GreenOrb" && typeOfPlac.tag=="GreenPlac")
        {
            ScoreUpdater.orbScore += 1;
            orbCatchFX.Play();
        }
        else if(other.tag == "GreenOrb" && typeOfPlac.tag != "GreenPlac" && typeOfPlac.tag != "DeathPlac")
        {
            ScoreUpdater.orbScore -= 1;
        }

        if (other.tag == "RedOrb" && typeOfPlac.tag == "RedPlac")
        {
            ScoreUpdater.orbScore += 1;
            orbCatchFX.Play();
        }
        else if (other.tag == "RedOrb" && typeOfPlac.tag != "RedPlac" && typeOfPlac.tag != "DeathPlac")
        {
            ScoreUpdater.orbScore -= 1;
        }

        if (other.tag == "BlueOrb" && typeOfPlac.tag == "BluePlac")
        {
            ScoreUpdater.orbScore += 1;
            orbCatchFX.Play();
        }
        else if (other.tag == "BlueOrb" && typeOfPlac.tag != "BluePlac" && typeOfPlac.tag != "DeathPlac")
        {
            ScoreUpdater.orbScore -= 1;
        }

        if(typeOfPlac.tag == "DeathPlac")
        {
            Destroy(other.gameObject);
            Debug.Log("JednaLopta");
        }
    }
}
