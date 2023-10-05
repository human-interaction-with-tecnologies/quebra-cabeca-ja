
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageT : MonoBehaviour
{
    public Image imgT;
	private bool isEnabled = false;
	public void ClickVewImage(){
		isEnabled = !isEnabled;
		if (isEnabled)
			imgT.gameObject.SetActive (true);
		else 
			imgT.gameObject.SetActive (false);
	}
	public void voltarLoginT(){
		StartCoroutine(ButtonVoltarT());
	}

	IEnumerator ButtonVoltarT(){
		PuzzlePiece.count = 0;
		SceneManager.LoadScene("imgTEscolha");
		yield return 0;
	}
}
