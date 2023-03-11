using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TextureApplicator : MonoBehaviour
{
    [FormerlySerializedAs("RenderTexture")] public RenderTexture MyRenderTexture;
    public SpriteRenderer SpriteRenderer;

    private Sprite _mySprite;
    
    // Start is called before the first frame update
    void Start()
    {
        // _mySprite = Sprite.Create(MyRenderTexture.,  new Rect(0, 0, MyRenderTexture.width, MyRenderTexture.height), Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
