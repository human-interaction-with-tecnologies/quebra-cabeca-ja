using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEscolha2 : MonoBehaviour
{

    public GameObject buttonJogar2;
    // Start is called before the first frame update
    public void Start()
    {
        if(ImageCropperDemo.Button2 == 1){
            buttonJogar2.SetActive(true);
            ImageCropperDemo.Button2 = 0;
        }
    }
}
