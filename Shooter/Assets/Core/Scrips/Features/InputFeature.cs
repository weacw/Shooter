using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
public class InputFeature : Feature
{
    public InputFeature(Contexts context)
    {
        Add(new InputSystem(context));
    }

}
