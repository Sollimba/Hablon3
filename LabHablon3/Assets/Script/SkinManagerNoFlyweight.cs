using UnityEngine;

public class SkinManagerNoFlyweight : MonoBehaviour
{
    public Sprite[] skinSprites;
    private int currentSkinIndex = 0;

    void Start()
    {
        ApplySkinToCharacter(this.gameObject);
    }

    void ApplySkinToCharacter(GameObject character)
    {
        SpriteRenderer renderer = character.GetComponent<SpriteRenderer>();
        if (renderer != null && skinSprites.Length > 0)
        {
            renderer.sprite = skinSprites[currentSkinIndex];
            currentSkinIndex = (currentSkinIndex + 1) % skinSprites.Length;
        }
    }
}
