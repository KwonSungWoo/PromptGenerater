using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptGeneratorScene : BaseScene
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.EScene.PromptGeneratorScene;

        //TODO

        return true;
    }



    public override void Clear()
    {
        //throw new System.NotImplementedException();
    }
}
