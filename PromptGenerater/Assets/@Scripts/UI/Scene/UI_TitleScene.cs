using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Define;

public class UI_TitleScene : UI_Scene
{
    enum GameObjects
    {
        StartImage
    }

    enum Texts
    {
        DisplayText
    }

    public Text DisplayText;

    public override bool Init()
    {
        if(base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        GetObject((int)GameObjects.StartImage).BindEvent((ent) =>
        {
            Debug.Log("ChangeScene");
            Managers.Scene.LoadScene(EScene.GameScene);
        });

        GetObject((int)GameObjects.StartImage).gameObject.SetActive(false);
        GetText((int)Texts.DisplayText).text = $" ";

        StartLoadAssects();

        return true;
    }

    void StartLoadAssects()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalcount) =>
        {
            Debug.Log($"{key} {count}/{totalcount}");

            if (count == totalcount)
            {
                Managers.Data.Init();

                GetObject((int)GameObjects.StartImage).gameObject.SetActive(true);
                GetText((int)(Texts.DisplayText)).text = "Touch to Start";
            }
        });
    }
}
