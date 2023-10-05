using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TelaFinalT : MonoBehaviour
{
    
    int count1 = 0; 
    // Start is called before the first frame update
    public static void Start(float soma)
    {
        
            soma = soma + 1;
        
        print("soma" + soma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
