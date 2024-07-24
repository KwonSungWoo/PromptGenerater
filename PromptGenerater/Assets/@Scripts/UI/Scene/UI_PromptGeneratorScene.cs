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
        Title,
        GeneratorVersion
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        //TODO

        return true;
    }
}
