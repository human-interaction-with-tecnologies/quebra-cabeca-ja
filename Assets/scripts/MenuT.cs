using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MenuT : MonoBehaviour
{
    // Start is called before the first frame update
 enum Options {
    Grid2X2,
		Grid3X3,
		Grid4X4,
		Grid5X5,
    };
    
    public Dropdown dropdown;
    public static int numeroPecas = 0;
    public Text selectedName;
    public GameObject buttonJogar;
    public static int resultado;
    public static int numeroCena = 100;



    void Start()
    {
        
        ListdropDown();
    }
    
    public void Jogar(){
        //StartCoroutine(ButtonJogar());
    }
 
    
    void ListdropDown()
    {
        string[] enumNames = Enum.GetNames(typeof(Options));
        List<string> names = new List<string>(enumNames);
 
        this.dropdown.AddOptions(names);
    }

    public void Dropdown_List1(){
      
    this.selectedName.text = $"value: {this.dropdown.value} {this.dropdown.captionText.text}";
    if(this.dropdown.value == 1){
        numeroPecas = 2;
        buttonJogar.SetActive(true);
       

      }
    if(this.dropdown.value == 2){
           numeroPecas = 3;
           buttonJogar.SetActive(true);   
          
       }
        
    if(this.dropdown.value == 3){
            
           numeroPecas = 4;
           buttonJogar.SetActive(true);
           
           
       }

    if(this.dropdown.value == 4){
           numeroPecas = 5;
         
           buttonJogar.SetActive(true);
        }

    }

    public void SceneTradicional(){
        if(  numeroPecas == 2){
             StartCoroutine(Tradicional_IMG());
             numeroCena = 2;
        }

        if(numeroPecas == 3){
            // StartCoroutine(Tradicional3x3());
            StartCoroutine(Tradicional_IMG());
             resultado = 9;
             numeroCena = 3;
        }

        if(numeroPecas == 4){
             StartCoroutine(Tradicional_IMG());
             resultado = 16;
             numeroCena = 4;
        }
        if(numeroPecas == 5){
             StartCoroutine(Tradicional_IMG());
             resultado = 25;
             numeroCena = 5;
        }
    }


    public static void SendRsult(){

    }


    
    IEnumerator Tradicional2x2(){
		SceneManager.LoadScene("2x2-Traditional");
    	yield return 0;
	 }

    IEnumerator Tradicional3x3(){
		SceneManager.LoadScene("3x3-Tradicional");
    	yield return 0;
	 }
    IEnumerator Tradicional_IMG(){
		SceneManager.LoadScene("imgTEscolha");
    	yield return 0;
	 }

    IEnumerator Tradicional4x4(){
		SceneManager.LoadScene("4x4-Tradicional");
    	yield return 0;
	 }

    IEnumerator Tradicional5x5(){
		SceneManager.LoadScene("5x5-Tradicional");
    	yield return 0;
	 }



   // IEnumerator ButtonJogar3(){
	//	SceneManager.LoadScene("Jogar");
    //	yield return 0;
	// }
}


 //if(this.dropdown.value == 1){
  //         buttonJogar.SetActive(true);
   //        numeroPecas = 2;
   //        StartCoroutine(Tradicional2x2());
   //        print(numeroPecas);
  //     }
        
    //    if(this.dropdown.value == 3){
            
     //      numeroPecas = 4;
      //     StartCoroutine(Tradicional4x4());
     //      print(numeroPecas);
           
      // }

      //  if(this.dropdown.value == 4){
            
      //     numeroPecas = 5;
      //     StartCoroutine(Tradicional5x5());
      //     print(numeroPecas);
           
     //  }
       

   // }