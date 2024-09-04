using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_References : UI_Base
{
    enum Texts
    {
        Text_Sref,
        Text_Cref,
    }

    enum InputFields
    {
        Input_Sref,
        Input_Cref,
    }

    enum Buttons
    {
        Button_CtrlV_Sref,
        Button_CtrlV_Cref,
    }



    public Button Button_CtrlV_Sref;
    public Button Button_CtrlV_Cref;

    public TMP_InputField Input_Sref;
    public TMP_InputField Input_Cref;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindTexts(typeof(Texts));
        BindInputFields(typeof(InputFields));
        BindButtons(typeof(Buttons));

        Input_Sref = GetInputField((int)InputFields.Input_Sref);
        Input_Cref = GetInputField((int)InputFields.Input_Cref);
        Button_CtrlV_Sref = GetButton((int)Buttons.Button_CtrlV_Sref);
        Button_CtrlV_Cref = GetButton((int)Buttons.Button_CtrlV_Cref);

        //TODO

        return true;
    }

    private void Start()
    {
        Input_Sref.onValueChanged.RemoveListener(delegate { Refresh(); });
        Input_Sref.onValueChanged.AddListener(delegate { Refresh(); });
        Input_Cref.onValueChanged.RemoveListener(delegate { Refresh(); });
        Input_Cref.onValueChanged.AddListener(delegate { Refresh(); });

        Button_CtrlV_Sref.onClick.RemoveListener(delegate { PasteText(); });
        Button_CtrlV_Sref.onClick.AddListener(delegate { PasteText(); });
        Button_CtrlV_Cref.onClick.RemoveListener(delegate { PasteText(); });
        Button_CtrlV_Cref.onClick.AddListener(delegate { PasteText(); });
    }

    public void CopyText()
    {
#if UNITY_WEBGL
        string textToCopy = Input_Sref.text;
        Application.ExternalCall("CopyToClipboard", textToCopy);
#endif
    }

    public void PasteText()
    {
#if UNITY_WEBGL
        Application.ExternalCall("PasteFromClipboard", gameObject.name);
#endif
    }

    // JavaScript에서 호출하는 함수
    public void OnPasteFromClipboard(string pastedText)
    {
        Input_Sref.text = pastedText;
    }

    public string GetSref() { return Input_Sref.text; }
    public string GetCref() { return Input_Cref.text; }
}
