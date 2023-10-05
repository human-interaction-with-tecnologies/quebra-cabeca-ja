using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Iniciar : MonoBehaviour
{

  
    // Start is called before the first frame update
    public void start() {
        StartCoroutine(NextConfig());
    }

    public void back() {
        StartCoroutine(BackHomeScreen());
    }
    public void MenuQuadrado(){
      StartCoroutine(NextMenuQuadrado());
    }

        public void MenuTradicional(){
      StartCoroutine(NextMenuTradicional());
    }

   IEnumerator NextConfig() {
    SceneManager.LoadScene("escolha");
    yield return 0;
  }

     IEnumerator BackHomeScreen() {
    SceneManager.LoadScene("Login");
    yield return 0;
  }

    IEnumerator NextMenuQuadrado() {
    SceneManager.LoadScene("Menu");
    yield return 0;
  }

    IEnumerator NextMenuTradicional() {
    SceneManager.LoadScene("MenuT");
    yield return 0;
  }
}
