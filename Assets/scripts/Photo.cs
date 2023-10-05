using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Photo : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(GalleryPhoto());
    }

    IEnumerator GalleryPhoto() {
        SceneManager.LoadScene("Gallery");
    yield return 0;
  }
}
