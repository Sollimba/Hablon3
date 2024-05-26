using UnityEngine;

public class SkinManager : MonoBehaviour
{
    private SkinFactory skinFactory;

    void Start()
    {
        skinFactory = new SkinFactory();

        ApplySkinToCharacter("Skin1", this.gameObject);
    }

    public void ApplySkinToCharacter(string skinKey, GameObject character) // Изменено на public
    {
        IFlyweightSkin skin = skinFactory.GetSkin(skinKey);
        if (skin != null)
        {
            skin.ApplySkin(character);
        }
        else
        {
            Debug.LogError("Skin not found: " + skinKey);
        }
    }
}
