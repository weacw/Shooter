using UnityEngine;
using Entitas;

public class InputController : MonoBehaviour
{
    private Systems m_System;
    private Contexts m_Context;
    // Use this for initialization
    void Start()
    {
        m_Context = Contexts.sharedInstance;
        m_System = CreateSystem(m_Context);
        m_System.Initialize();
    }

    private Systems CreateSystem(Contexts context)
    {
        return new Feature("Input System").Add(new InputFeature(context)).Add(new RenderFeature(context));
    }

    // Update is called once per frame
    void Update()
    {
        m_System.Execute();
        m_System.Cleanup();

    }
}
