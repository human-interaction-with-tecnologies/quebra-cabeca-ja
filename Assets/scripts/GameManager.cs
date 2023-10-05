using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public Text text;
    public static GameObject currentPiece;
    public static int currentScore = 0, scoreTotal = 0;
    private static int level;
    public GameObject ImagemFinal;
	  float cronometro ;
    float tempoLimite = 1;
  
    void Update(){
        
        
         print(currentScore);
         print("valor level" + level);

       switch (level)
       {
        case 0:
            if(currentScore == scoreTotal){
                
                print(currentScore);
                print(scoreTotal);
                print("Parabens");
                Cronometro();
               // ImagemFinal.SetActive(true);
                //text.text = "Parabens";
                //currentScore = 0;
                
                //level = level + 1;
                //print(level);
              //  Timer.estopTime = true;
                 //level = 0;
               // StartCoroutine(ButtonLevel());
            }        
            break;
       // case 1:
        //    if(currentScore == scoreTotal){
          //  print(currentScore);
          //  print(scoreTotal);
           //     print("Parabens");
              //  text.text = "Parabens vc ganhou";
            //    currentScore = 0;
            //    level = level + 1;
             //   Timer.estopTime = true;
             //   StartCoroutine(ButtonLevel_2());
           // }        
          ///  break;
     //   case 2:
          //  if(currentScore == scoreTotal){
          //  print(currentScore);
          //  print(scoreTotal);
            //    print("Parabens");
              //  text.text = "Parabens vc ganhou";
             //   currentScore = 0;
             //   level = level + 1;
             //   StartCoroutine(ButtonLevel_2());
          //  }        
           // break;
       }
        
    }

    IEnumerator ButtonLevel(){
		SceneManager.LoadScene("Jogar-2");
        Update();
    	yield return 0;
	 }
    IEnumerator ButtonLevel_1(){
		SceneManager.LoadScene("Jogar-3");
        Update();
    	yield return 0;
	 }
         IEnumerator ButtonLevel_2(){
		SceneManager.LoadScene("Menu");
        Update();
    	yield return 0;
	 }

   void Cronometro(){
        cronometro += Time.deltaTime;
        
            if(cronometro >=  tempoLimite){
                print(cronometro);
                ImagemFinal.SetActive(true);
               // count = 0;
               // count1 = 0;
                currentScore = 0;
            }

    }
}
