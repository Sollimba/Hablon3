using System.Collections.Generic;
using UnityEngine;

public class SkinFactory
{
    private Dictionary<string, IFlyweightSkin> skins = new Dictionary<string, IFlyweightSkin>();

    public IFlyweightSkin GetSkin(string key)
    {
        if (skins.ContainsKey(key))
        {
            return skins[key];
        }

        // Загружаем ресурс скин по ключу
        Sprite sprite = Resources.Load<Sprite>(key);
        if (sprite != null)
        {
            IFlyweightSkin skin = new FlyweightSkin(sprite);
            skins[key] = skin;
            return skin;
        }

        return null;
    }
}
