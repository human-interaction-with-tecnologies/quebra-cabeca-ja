using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gallery : MonoBehaviour
{
public UnityEngine.UI.Image img;

//public static UnityEngine.UI.Image imgGallery;
public static Texture2D texture_teste;
public static Texture2D texture_teste_1;
public static Texture2D texture_teste_3;
public static Texture2D texture_teste_4;
private Vector3 scaleChange;
public GameObject buttonJogar;
public static int Button = 0;


public void start(){
  img = GameObject.Find("Main Camera/Canvas/image").GetComponent<UnityEngine.UI.Image>();
        //scaleChange = new Vector3(5000f, 5000f, 5000f);
        //img.transform.localScale += scaleChange;
        
}
void Update() {
  if( Input.GetMouseButtonDown( 0 ) )
  {
    {
      // Don't attempt to pick media from Gallery/Photos if
      // another media pick operation is already in progress
      if( NativeGallery.IsMediaPickerBusy() )
        return;

    }
  }
}

public void PickImage( int maxSize ) {
  //print(maxSize);
  NativeGallery.Permission permission = NativeGallery.GetImageFromGallery( ( path ) =>
  {
    Button = 1;
    buttonJogar.SetActive(true);
    Gallery.Button = 0;
    Debug.Log( "Image path: " + path );
    if( path != null )
    {
      // Create Texture from selected image
      Texture2D texture = NativeGallery.LoadImageAtPath( path, maxSize );
      //texture.isReadable = true;
      if( texture == null )
      {
        Debug.Log( "Couldn't load texture from " + path );
        return;
      }

     // texture_teste = ImageCropperDemo.texture_Crop;
      
      // Assign texture to a temporary quad and destroy it after 5 seconds
       GameObject quad = GameObject.CreatePrimitive( PrimitiveType.Quad );
      quad.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
      quad.transform.forward = Camera.main.transform.forward;
      quad.transform.localScale = new Vector3( 1f, texture.height / (float) texture.width, 1f );
      
      
       Material material = quad.GetComponent<Renderer>().material;
      //if( !material.shader.isSupported ) // happens when Standard shader is not included in the build
       // material.shader = Shader.Find( "Legacy Shaders/Diffuse" );
        material.shader = Shader.Find("UI/Unlit/Detail");

        material.mainTexture = texture;    
        
        //img.material = material;
        //img.material = material;
        img.material = material;
        
       // texture_teste = ImageCropperDemo.texture_Crop;
        //texture_teste_1 = duplicateTexture(ImageCropperDemo.texture_Crop);
        
        //img.material = material;
        //texture_teste_1 = duplicateTexture(ImageCropperDemo.texture_Crop);
        //imgGallery.material = material;
        //texture_teste_1 = duplicateTexture(texture_teste);
         // texture_teste_1 = duplicateTexture(texture_teste);
      // If a procedural texture is not destroyed manually, 
      // it will only be freed after a scene change
      //Destroy( texture, 5f );
      
    }
  }, "Select a JPG image", "image/jpg" );

  Debug.Log( "Permission result: " + permission );
}
 Texture2D duplicateTexture(Texture2D source)
 {
    
     RenderTexture renderTex = RenderTexture.GetTemporary(
                 source.width,
                 source.height,
                 0,
                 RenderTextureFormat.Default,
                 RenderTextureReadWrite.Linear);
 
     Graphics.Blit(source, renderTex);
     RenderTexture previous = RenderTexture.active;
     RenderTexture.active = renderTex;
     Texture2D readableText = new Texture2D(source.width, source.height);
     readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
     readableText.Apply();
     RenderTexture.active = previous;
     RenderTexture.ReleaseTemporary(renderTex);
     return readableText;
 }
}





