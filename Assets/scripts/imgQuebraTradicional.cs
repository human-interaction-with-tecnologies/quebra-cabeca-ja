using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class imgQuebraTradicional : MonoBehaviour
{
   
    // Start is called before the first frame update
    public void imgAnimais()
    {
        if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Animais());
        }
        
        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Animais());
        }    

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Animais());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Animais());
        }
    }


    public void imgTerra()
    {
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Terra());
        }
        
        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Terra());
        }

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Terra());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Terra());
        }
        
    }


    public void imgMar()
    {
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Mar());
        }
        
        if(MenuT.numeroPecas == 3){
           StartCoroutine(Tradicional3x3Mar());
        }

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Mar());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Mar());
        }
        
    }

    public void imgSistemaSolar()
    {
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2SistemaSolar());
        }
        
        if(MenuT.numeroPecas == 3){
          StartCoroutine(Tradicional3x3SistemaSolar());
        }

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4SistemaSolar());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5SistemaSolar());
        }
    
    }

    public void imgUrso(){
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Ursos());
        }

         if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Urso());
        }

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Urso());
        }

        
        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Urso());
        }
    }

    public void imgRcuires(){
         if(MenuT.numeroPecas == 2){
            StartCoroutine( Tradicional2x2Arcuires());
        }

        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Arcuires());
        }    

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Arcuires());
        }  

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Arcuires());
        }   
    }

    public void imgCasa(){
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Casa());
        } 
        
        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Casa());
        }

         if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Casa());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Casa());
        }
    }

    public void imgCarro(){
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Carro());
        }
        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Carro());
        }
          if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Carro());
        }

        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Carro());
        }
    }

        public void imgBarco(){
         if(MenuT.numeroPecas == 2){
            StartCoroutine(Tradicional2x2Barco());
        }

        if(MenuT.numeroPecas == 3){
            StartCoroutine(Tradicional3x3Barco());
        }

        if(MenuT.numeroPecas == 4){
            StartCoroutine(Tradicional4x4Barco());
        }
        
        if(MenuT.numeroPecas == 5){
            StartCoroutine(Tradicional5x5Barco());
        }
    }




    // ==================== 2x2 quebra ==================
    IEnumerator Tradicional2x2Animais(){
		SceneManager.LoadScene("2x2-Traditional");
    	yield return 0;
	}

        
    IEnumerator Tradicional2x2Terra(){
		SceneManager.LoadScene("2x2-Traditional-terra");
    	yield return 0;
	}

    IEnumerator Tradicional2x2Mar(){
		SceneManager.LoadScene("2x2-Traditional-mar");
    	yield return 0;
	}

    IEnumerator Tradicional2x2SistemaSolar(){
		SceneManager.LoadScene("2x2-Traditional-sistema-solar");
    	yield return 0;
	}

    IEnumerator Tradicional2x2Ursos(){
		SceneManager.LoadScene("2x2-Traditional-urso");
    	yield return 0;
	}

    IEnumerator Tradicional2x2Arcuires(){
		SceneManager.LoadScene("2x2-Traditional-arcuires");
    	yield return 0;
	}

    IEnumerator Tradicional2x2Casa(){
		SceneManager.LoadScene("2x2-Traditional-casa");
    	yield return 0;
	}

    IEnumerator Tradicional2x2Carro(){
		SceneManager.LoadScene("2x2-Traditional-carro");
    	yield return 0;
	}

        IEnumerator Tradicional2x2Barco(){
		SceneManager.LoadScene("2x2-Traditional-Barco");
    	yield return 0;
	}




    // ==================== 3x3 quebra ==================
    IEnumerator Tradicional3x3Terra(){
		SceneManager.LoadScene("3x3-Tradicional");
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

    
    // ==================== 4x4 quebra ==================
    IEnumerator Tradicional4x4SistemaSolar(){
		SceneManager.LoadScene("4x4-Tradicional");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Animais(){
		SceneManager.LoadScene("4x4-Tradicional-animais");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Mar(){
		SceneManager.LoadScene("4x4-Tradicional-mar");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Terra(){
		SceneManager.LoadScene("4x4-Tradicional-terra");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Urso(){
		SceneManager.LoadScene("4x4-Tradicional-urso");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Arcuires(){
		SceneManager.LoadScene("4x4-Tradicional-arcuires");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Casa(){
		SceneManager.LoadScene("4x4-Tradicional-casa");
    	yield return 0;
	}

    IEnumerator Tradicional4x4Carro(){
		SceneManager.LoadScene("4x4-Tradicional-carro");
    	yield return 0;
	}

        IEnumerator Tradicional4x4Barco(){
		SceneManager.LoadScene("4x4-Tradicional-barco");
    	yield return 0;
	}

    // ==================== 5x5 quebra ==================
    IEnumerator Tradicional5x5Mar(){
		SceneManager.LoadScene("5x5-Tradicional");
    	yield return 0;
	}

    IEnumerator Tradicional5x5SistemaSolar(){
		SceneManager.LoadScene("5x5-Tradicional-sistema-solar");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Animais(){
		SceneManager.LoadScene("5x5-Tradicional-animais");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Terra(){
		SceneManager.LoadScene("5x5-Tradicional-terra");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Urso(){
		SceneManager.LoadScene("5x5-Tradicional-urso");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Arcuires(){
		SceneManager.LoadScene("5x5-Tradicional-arcuires");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Casa(){
		SceneManager.LoadScene("5x5-Tradicional-casa");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Carro(){
		SceneManager.LoadScene("5x5-Tradicional-carro");
    	yield return 0;
	}

    IEnumerator Tradicional5x5Barco(){
		SceneManager.LoadScene("5x5-Tradicional-barco");
    	yield return 0;
	}
}
