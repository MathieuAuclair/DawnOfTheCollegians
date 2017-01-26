using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageHandler : MonoBehaviour {

    public Sprite currentImage;

    public Sprite img1;
    public Sprite img2;
    public Sprite img3;
    public Sprite img4;
    public Sprite img5;
    public Sprite img6;
    public Sprite img7;
    public Sprite img8;
    public Sprite img9;
   
    public void SetImage( ItemType itemType )
    {
        Image imageUI = GetComponent<Image>();
        switch (itemType)
        {
            case ItemType.Keyboard: imageUI.sprite = img1;  break;
            case ItemType.Screen : imageUI.sprite = img2;break;
            case ItemType.Bat: imageUI.sprite = img3; break;
        }
        imageUI.type = Image.Type.Simple;
    }
}
