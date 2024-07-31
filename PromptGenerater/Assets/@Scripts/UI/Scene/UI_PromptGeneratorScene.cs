using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Define;

public class UI_PromptGeneratorScene : UI_Scene
{
    public Transform optionsParent; // 부모 오브젝트를 할당하는 필드

    public UI_Setting set;
    public UI_Options opt;
    public UI_Generate gen;

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
        set = optionsParent.Find("UI_Setting").GetComponent<UI_Setting>();
        opt = optionsParent.Find("UI_Options").GetComponent<UI_Options>();
        gen = optionsParent.Find("UI_Generate").GetComponent<UI_Generate>();

        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));


        //TODO

        return true;
    }

    private void Start()
    {

        Managers.UIData.Init(set, opt, gen);
    }
}
