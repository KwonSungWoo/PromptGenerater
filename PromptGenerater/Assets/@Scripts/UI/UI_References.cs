using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

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

    public TMP_InputField Input_Sref;
    public TMP_InputField Input_Cref;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindTexts(typeof(Texts));
        BindInputFields(typeof(InputFields));

        Input_Sref = GetInputField((int)InputFields.Input_Sref);
        Input_Cref = GetInputField((int)InputFields.Input_Cref);
        //TODO

        return true;
    }

    private void Start()
    {
        Input_Sref.onValueChanged.RemoveListener(delegate { Refresh(); });
        Input_Sref.onValueChanged.AddListener(delegate { Refresh(); });
        Input_Cref.onValueChanged.RemoveListener(delegate { Refresh(); });
        Input_Cref.onValueChanged.AddListener(delegate { Refresh(); });
    }

    public string GetSref() { return Input_Sref.text; }
    public string GetCref() { return Input_Cref.text; }
}
