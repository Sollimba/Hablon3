using UnityEngine;

public class FlyweightSkin : IFlyweightSkin
{
    private Sprite skinSprite;

    public FlyweightSkin(Sprite sprite)
    {
        this.skinSprite = sprite;
    }

    public void ApplySkin(GameObject character)
    {
        SpriteRenderer renderer = character.GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            renderer.sprite = skinSprite;
        }
    }
}
