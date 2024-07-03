using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.EScene.TitleScene;

        //StartLoadAssects();

        return true;
    }

    void StartLoadAssects()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalcount) =>
        {
            Debug.Log($"{key} {count}/{totalcount}");

            if (count == totalcount)
            {
                //Managers.Data.Init();
            }
        });
    }

    public override void Clear()
    {
        //throw new System.NotImplementedException();
    }

}
