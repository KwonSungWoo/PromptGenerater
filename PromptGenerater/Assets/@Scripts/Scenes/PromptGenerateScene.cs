using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptGenerateScene : BaseScene
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.EScene.PromptGenerateScene;

        //StartLoadAssects();

        return true;
    }



    public override void Clear()
    {
        //throw new System.NotImplementedException();
    }
}
