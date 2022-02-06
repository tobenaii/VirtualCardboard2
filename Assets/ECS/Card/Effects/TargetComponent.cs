using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct Target : IComponentAuthoring<Target, TargetComponent>
{
    public Entity dealer;
    public Entity target;
}

public class TargetComponent : CardEffectAuthoring<Target>
{
    protected override Target AuthorComponent(World world)
    {
        return new Target();
    }
}