using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Senatradicional3x3 : MonoBehaviour
{
    // Start is called before the first frame update


    public void imgAnimais()
    {
        StartCoroutine(Tradicional3x3Animais());
    }


    public void imgTerra()
    {
        StartCoroutine(Tradicional3x3Terra());
    }

    public void imgMar()
    {
        StartCoroutine(Tradicional3x3Mar());
    }

    public void imgSistemaSolar()
    {
        StartCoroutine(Tradicional3x3SistemaSolar());
    }

    public void imgArcuires()
    {
        StartCoroutine(Tradicional3x3Arcuires());
    }

    public void imgCasa()
    {
        StartCoroutine(Tradicional3x3Casa());
    }

    public void imgUrso()
    {
        StartCoroutine(Tradicional3x3Urso());
    }

    public void imgCarro()
    {
        StartCoroutine(Tradicional3x3Carro());
    }

        public void imgBarco()
    {
        StartCoroutine(Tradicional3x3Barco());
    }

     IEnumerator Tradicional3x3Terra(){
		SceneManager.LoadScene("3x3-Tradicional");
    	yield return 0;
	}

     IEnumerator Tradicional3x3Arcuires(){
		SceneManager.LoadScene("3x3-Tradicional-arcuires");
    	yield return 0;
	}

     IEnumerator Tradicional3x3Casa(){
        SceneManager.LoadScene("3x3-Tradicional-casa");
        yield return 0;
      }

    IEnumerator Tradicional3x3Urso(){
        SceneManager.LoadScene("3x3-Tradicional-urso");
        yield return 0;
      }

    IEnumerator Tradicional3x3Carro(){
        SceneManager.LoadScene("3x3-Tradicional-carro");
        yield return 0;
      }

          IEnumerator Tradicional3x3Barco(){
        SceneManager.LoadScene("3x3-Tradicional-barco");
        yield return 0;
      }

    IEnumerator Tradicional3x3Animais(){
		SceneManager.LoadScene("3x3-Tradicional-animais");
    	yield return 0;
	}

    IEnumerator Tradicional3x3Mar(){
		SceneManager.LoadScene("3x3-Tradicional-mar");
    	yield return 0;
	}
    IEnumerator Tradicional3x3SistemaSolar(){
		SceneManager.LoadScene("3x3-Tradicional-sistema-solar");
    	yield return 0;
	}

    
}
