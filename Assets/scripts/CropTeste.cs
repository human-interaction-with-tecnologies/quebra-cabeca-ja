using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CropTeste : MonoBehaviour
{
    
    

    public void Jogar(){
        StartCoroutine(ButtonJogar());
    }

     public void Jogar1(){
        StartCoroutine(ButtonJogar1());
    }

    IEnumerator ButtonJogar(){
		SceneManager.LoadScene("DemoScene");
    	yield return 0;
	 }

         IEnumerator ButtonJogar1(){
		SceneManager.LoadScene("Jogar");
    	yield return 0;
	 }
 
}
