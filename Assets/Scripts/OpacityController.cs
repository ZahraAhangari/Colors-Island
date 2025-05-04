using UnityEngine;

public class OpacityController : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private Color initialColor;
    private Color fadedColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        initialColor = spriteRenderer.color;

        float grayScaleValue = 0.5f; 
        float initialAlpha = 0.5f; 

        fadedColor = new Color(grayScaleValue, grayScaleValue, grayScaleValue, initialAlpha);

        spriteRenderer.color = fadedColor;
    }

    public void SetOpaque()
    {
        spriteRenderer.color = initialColor;
    }

}

