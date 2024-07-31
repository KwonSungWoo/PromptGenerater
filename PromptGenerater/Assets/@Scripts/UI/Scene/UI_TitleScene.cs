using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Define;

public class UI_TitleScene : UI_Scene
{

    enum GameObjects
    {
        Image_Start
    }

    enum Texts
    {
        Text_Display
    }

    public override bool Init()
    {
        if(base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        //클릭시 씬 전환
        GetObject((int)GameObjects.Image_Start).BindEvent((ent) =>
        {
            Debug.Log("ChangeScene");
            Managers.Scene.LoadScene(EScene.PromptGeneratorScene);
        });

        GetObject((int)GameObjects.Image_Start).gameObject.SetActive(false);
        GetText((int)Texts.Text_Display).text = $" ";

        Debug.Log("Starting asset load");
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
                Debug.Log("All assets loaded");
                GetObject((int)GameObjects.Image_Start).gameObject.SetActive(true);
                GetText((int)(Texts.Text_Display)).text = "Touch to Start";

                Managers.Data.Init();
                Debug.Log("Initializing data");
            }
        });
    }
}
