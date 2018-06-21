using UnityEngine;
using System.Collections;
using Entitas;

public class CreateCharacterSystem : IInitializeSystem
{
    readonly GameContext m_Context;
    public CreateCharacterSystem(Contexts context)
    {
        m_Context = context.game;
    }

    public void Initialize()
    {        
        GameEntity tmp_Entity = m_Context.CreateEntity();
        tmp_Entity.AddCharacterRender(Resources.Load<GameObject>("Controller"));
        Object.Instantiate<GameObject>(tmp_Entity.characterRender.character); 
        
    }
}
