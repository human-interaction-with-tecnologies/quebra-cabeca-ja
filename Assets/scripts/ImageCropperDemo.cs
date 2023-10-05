using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


	public class ImageCropperDemo : MonoBehaviour
	{
		public RawImage croppedImageHolder;
		public Text croppedImageSize;
		public static Texture2D texture_Crop;
		public Toggle ovalSelectionInput, autoZoomInput;
		public InputField minAspectRatioInput, maxAspectRatioInput;
		public static int Button2 = 0;

		public void Crop()
		{
			// If image cropper is already open, do nothing
			if( ImageCropper.Instance.IsOpen )
				return;
			Button2 = 1;
			StartCoroutine( TakeScreenshotAndCrop() );
		}

		private IEnumerator TakeScreenshotAndCrop()
		{
			yield return new WaitForEndOfFrame();

			bool ovalSelection = false;
			bool autoZoom = false;

			float minAspectRatio, maxAspectRatio;
			if( !float.TryParse( minAspectRatioInput.text, out minAspectRatio ) )
				minAspectRatio = 0f;
			if( !float.TryParse( maxAspectRatioInput.text, out maxAspectRatio ) )
				maxAspectRatio = 0f;

			Texture2D screenshot = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
			screenshot.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
			screenshot.Apply();

			ImageCropper.Instance.Show( screenshot, ( bool result, Texture originalImage, Texture2D croppedImage ) =>
			{
				// Destroy previously cropped texture (if any) to free memory
				Destroy( croppedImageHolder.texture, 5f );

				// If screenshot was cropped successfully
				if( result )
				{
					// Assign cropped texture to the RawImage
					croppedImageHolder.enabled = true;
					croppedImageHolder.texture = croppedImage;

					GameObject quad = GameObject.CreatePrimitive( PrimitiveType.Quad );
					Material material = quad.GetComponent<Renderer>().material;
					material.shader = Shader.Find("UI/Unlit/Detail");
      				material.mainTexture = croppedImage;   
					texture_Crop = duplicateTexture(croppedImage);

					Vector2 size = croppedImageHolder.rectTransform.sizeDelta;
					if( croppedImage.height <= croppedImage.width )
						size = new Vector2( 500f, 500f * ( croppedImage.height / (float) croppedImage.width ) );
					else
						size = new Vector2( 500f * ( croppedImage.width / (float) croppedImage.height ), 500f );
					croppedImageHolder.rectTransform.sizeDelta = size;

					croppedImageSize.enabled = true;
					croppedImageSize.text = "Image size: " + croppedImage.width + ", " + croppedImage.height;
					//texture_Crop = croppedImage;
				}
				else
				{
					croppedImageHolder.enabled = false;
					croppedImageSize.enabled = false;
				}

				// Destroy the screenshot as we no longer need it in this case
				Destroy( screenshot );
			},
			settings: new ImageCropper.Settings()
			{
				ovalSelection = ovalSelection,
				autoZoomEnabled = autoZoom,
				imageBackground = Color.clear, // transparent background
				selectionMinAspectRatio = minAspectRatio,
				selectionMaxAspectRatio = maxAspectRatio

			},
			croppedImageResizePolicy: ( ref int width, ref int height ) =>
			{
				// uncomment lines below to save cropped image at half resolution
				//width /= 2;
				//height /= 2;
			} );
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
