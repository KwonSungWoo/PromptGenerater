using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

    public Button Button_Generate;
    public Button Button_Copy;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButtons(typeof(Buttons));
        BindTexts(typeof(Texts));

        Button_Generate = GetButton((int)Buttons.Button_Generate);
        Button_Copy = GetButton((int)Buttons.Button_Copy);

        //TODO

        GetText((int)Texts.Text_Sentence).text = $"Click The Shuffle Button";

        return true;
    }

    private void Start()
    {
        Button_Generate.onClick.RemoveListener(delegate { Shuffle(); });
        Button_Generate.onClick.AddListener(delegate { Shuffle(); });
        Button_Generate.onClick.RemoveListener(delegate { Refresh(); });
        Button_Generate.onClick.AddListener(delegate { Refresh(); });
        Button_Copy.onClick.RemoveListener(delegate { CopytoClipboard(); });
        Button_Copy.onClick.AddListener(delegate { CopytoClipboard(); });
    }

    private void CopytoClipboard()
    {
        GUIUtility.systemCopyBuffer = Managers.UIData.GetFinalSentence();
    }

    public void SetSentence()
    {
        GetText((int)Texts.Text_Sentence).text = Managers.UIData.GetFinalSentence();
    }
}
