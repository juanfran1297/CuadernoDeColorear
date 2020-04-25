using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public AudioSource sonidoFoto;

    public GameObject canvasGaleria;

    private void Start()
    {
        canvasGaleria = GameObject.Find("CanvasGaleria");
        canvasGaleria.SetActive(false);
    }

    private void OnMouseDown()
    {
        DoScreenshot();
    }
    public void DoScreenshot()
    {
        StartCoroutine(TakeScreenshotAndSave());
        sonidoFoto.Play();
    }

    //IEnumerator ScreenshotEncode()
    //{
    //    yield return new WaitForEndOfFrame();
    //    string datacion = System.DateTime.Now.ToFileTime().ToString();
    //    NativeGallery.SaveImageToGallery(myTexture, "GalleryTest", "Img {0}.png");
    //    ScreenCapture.CaptureScreenshot(datacion + ".png");
    //}

    private IEnumerator TakeScreenshotAndSave()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        // Save the screenshot to Gallery/Photos
        Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, "CuadernoDeColorear", "ImagenDrilo.png"));
        NativeGallery.SaveImageToGallery(ss, "CuadernoDeColorear", "ImagenDrilo.png");

        canvasGaleria.SetActive(true);
        // To avoid memory leaks
        Destroy(ss);
    }
}
