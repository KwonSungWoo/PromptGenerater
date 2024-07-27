using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Generate : UI_Base
{
    enum Buttons
    {
        Button_Generate,
        Button_Copy
    }

    enum Texts
    {
        Text_Generate,
        Text_Copy,
        Text_Sentence
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButtons(typeof(Buttons));
        BindTexts(typeof(Texts));

        //TODO

        GetText((int)Texts.Text_Sentence).text = $"Click The Shuffle Button";

        return true;
    }

    public void SetSentence()
    {
        GetText((int)Texts.Text_Sentence).text = Managers.UIData.GetFinalSentence();
    }
}
