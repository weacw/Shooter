using UnityEngine;
using Entitas;

public class CharacterRenderComponent : IComponent
{
    public GameObject character;
}

public static class CharacterRenderComponentExtension
{
    public static Transform GetTransform(this GameEntity e)
    {
        return e.characterRender.character.transform;
    }
}