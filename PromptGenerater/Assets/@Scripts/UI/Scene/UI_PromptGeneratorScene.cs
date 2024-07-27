using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Define;

public class UI_PromptGeneratorScene : UI_Scene
{
    enum GameObjects
    {
        //BackgroundImage   
    }

    enum Texts
    {
        Text_Title,
        Text_GeneratorVersion
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        Managers.UIData.Init();

        //TODO

        return true;
    }
}
