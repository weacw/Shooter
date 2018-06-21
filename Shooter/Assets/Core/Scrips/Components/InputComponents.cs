using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;


[Input]
public class KeyDirectionComponent : IComponent
{
    public Vector2 move;
}

[Input]
public class MouseDirectionComponent : IComponent
{
    public Vector2 direction;
}

[Input]
public class MouseLeftInputComponent : IComponent
{
    public bool status;
}

[Input]
public class MouseRightInputComponent : IComponent
{
    public bool status;
}


[Input, Unique]
public class UserInput : IComponent
{
}

