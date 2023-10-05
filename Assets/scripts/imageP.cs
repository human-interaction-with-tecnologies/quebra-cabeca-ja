using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class imageP : MonoBehaviour
{
    public UnityEngine.UI.Image imgP;
	private bool isEnabled = false;
    // Start is called before the first frame update
    public void ClickVewImage(){
		isEnabled = !isEnabled;
		if (isEnabled)
			imgP.gameObject.SetActive (true);
		else 
			imgP.gameObject.SetActive (false);
	}

    public void voltarLoginP(){
		StartCoroutine(ButtonVoltarP());
	}

    IEnumerator ButtonVoltarP(){
		SceneManager.LoadScene("Menu");
		yield return 0;
	}
}
