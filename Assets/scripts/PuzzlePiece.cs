using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzlePiece : MonoBehaviour
{
   // public  GameObject teste;
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public GameObject ImagemFinal;
    public AudioClip clip;
    

    public static int count = 0;
    public static int count1 = 0;
    public static int numeroCena1;
	float cronometro ;
    float tempoLimite = 1;
    
    void Start()
    {
         
         
        RightPosition = transform.position;
        ///////// assim que o jogo comeca
        ///////// as pecas ficarao dispostas em posicoes aleatorias
       // transform.position = new Vector3(Random.Range(1f, 8.4f), Random.Range(3.2f, -3.2f));
        transform.position = new Vector3(Random.Range(0.5f, 8.4f), Random.Range(3.2f, -1f));
    }
 
    void Update()
    {
       
        // caso o jogador chegue com a peca perto da sua posicao de origem
        // ela vai encaixar automaticamente);
        if (Vector3.Distance(transform.position, RightPosition) < 0.8f) {
            if(!Selected) {
            if(InRightPosition == false) { 
            transform.position = RightPosition;
            // quando encaixada, ela nao pode ser selecionada
            InRightPosition = true;
            count++;
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            print("count"+ count);
            print("aqui");
            GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }
        }
        
        count1 = count; 

        if(count1 == 4 && MenuT.numeroCena == 2){
            //ImagemFinal.SetActive(true);
           // count = 0;
           // count1 = 0;
            Cronometro();
        }

        if(count1 == 9 && MenuT.numeroCena == 3){
            Cronometro();
          //  ImagemFinal.SetActive(true);
          //  count = 0;
           // count1 = 0;
        }

        if(count1 == 16 && MenuT.numeroCena == 4){
            Cronometro();
         //   ImagemFinal.SetActive(true);
           // count = 0;
           // count1 = 0;
        }

        if(count1 == 25 && MenuT.numeroCena == 5){
            Cronometro();
           // ImagemFinal.SetActive(true);
           // count = 0;
           // count1 = 0;
        }

        
    }

    void Cronometro(){
        cronometro += Time.deltaTime;
        
            if(cronometro >=  tempoLimite){
                print(cronometro);
                ImagemFinal.SetActive(true);
                count = 0;
                count1 = 0;
            }

    }
   

}
