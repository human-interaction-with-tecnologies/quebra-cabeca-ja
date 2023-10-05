using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class esoclhaButton : MonoBehaviour
{
    public GameObject buttonJogar;

    // Start is called before the first frame update
    public void Start()
    {
        if(Gallery.Button == 1){
            buttonJogar.SetActive(true);
            Gallery.Button = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
