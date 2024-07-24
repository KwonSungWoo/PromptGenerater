using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static Define;

public class BaseObject : InitBase
{
    public EObjectType ObjectType { get; protected set; } = EObjectType.None;

    #region Stats
    public int Number { get; set; }
    public string Name { get; set; } = "None";
    #endregion

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        return true;
    }
}
