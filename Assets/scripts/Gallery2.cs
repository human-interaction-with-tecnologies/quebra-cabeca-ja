using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gallery2 : MonoBehaviour
{
   public UnityEngine.UI.Image img;

public void start(){
  img = GameObject.Find("Main Camera/Canvas/image").GetComponent<UnityEngine.UI.Image>();
}
    void Update()
    {
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

    public void PickImage( int maxSize )
  {
  NativeGallery.Permission permission = NativeGallery.GetImageFromGallery( ( path ) =>
  {
    Debug.Log( "Image path: " + path );
    if( path != null )
    {
      // Create Texture from selected image
      Texture2D texture = NativeGallery.LoadImageAtPath( path, maxSize );
      if( texture == null )
      {
        Debug.Log( "Couldn't load texture from " + path );
        return;
      }

      // Assign texture to a temporary quad and destroy it after 5 seconds
      GameObject quad = GameObject.CreatePrimitive( PrimitiveType.Quad );
      quad.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
      quad.transform.forward = Camera.main.transform.forward;
      quad.transform.localScale = new Vector3( 1f, texture.height / (float) texture.width, 1f );

      Material material = quad.GetComponent<Renderer>().material;
     // if( !material.shader.isSupported ) // happens when Standard shader is not included in the build
        //material.shader = Shader.Find( "Legacy Shaders/Diffuse" );
        material.shader = Shader.Find("UI/Unlit/Detail");
        material.mainTexture = texture;

      img.material = material;
      Destroy(quad, 0f);
     
      // If a procedural texture is not destroyed manually, 
      // it will only be freed after a scene change
      //Destroy( texture, 5f );
      
    }
  }, "Select a JPG image", "image/jpg" );

  Debug.Log( "Permission result: " + permission );
}
}
