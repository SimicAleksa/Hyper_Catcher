using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerate : MonoBehaviour
{
    
    public GameObject[] orbFall;
    public bool genOrb = false;
    public int orbLoc;
    public int orbCol;

    public float xPos;

    // Update is called once per frame
    void Update()
    {
        if(!genOrb){
            genOrb = true;
            orbLoc = Random.Range(1,4);
            orbCol = Random.Range(0,3);
            if(orbLoc==1){
                xPos = -1.25f;
            }
            else if(orbLoc == 2){
                xPos = 0;
            }
            else{
                xPos = 1.25f;
            }
            StartCoroutine(OrbFalling());
        }
    }

    IEnumerator OrbFalling(){
        Instantiate(orbFall[orbCol], new Vector3(xPos,6,0),Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        genOrb = false;
    }
}
