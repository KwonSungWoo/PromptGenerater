using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static Define;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using System;
using UnityEngine.UI;

public class UI_Setting : UI_Base
{
    enum GameObjects
    {
        None,
    }

    enum Texts
    {
        Text_Setting,
    }

    enum Dropdowns
    {
        Dropdown_Version,
        Dropdown_Ratio,
        Dropdown_Stylize
    }

    public TMP_Dropdown dropdwon_Version;
    public TMP_Dropdown dropdwon_Ratio;
    public TMP_Dropdown dropdwon_Stylize;


    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));
        BindDropdowns(typeof(Dropdowns));


        dropdwon_Version = GetTMP_Dropdown((int)Dropdowns.Dropdown_Version);
        dropdwon_Ratio = GetTMP_Dropdown((int)Dropdowns.Dropdown_Ratio);
        dropdwon_Stylize = GetTMP_Dropdown((int)Dropdowns.Dropdown_Stylize);

        initDropdown(dropdwon_Version, Managers.Data.VersionDic, DefaultSetting.VERSTION);
        initDropdown(dropdwon_Ratio, Managers.Data.RatioDic, DefaultSetting.RATIO);
        initDropdown(dropdwon_Stylize, Managers.Data.StylizeDic, DefaultSetting.STYLIZE);

        dropdwon_Version.onValueChanged.RemoveListener(delegate {Refresh();});
        dropdwon_Version.onValueChanged.AddListener(delegate {Refresh();});
        dropdwon_Ratio.onValueChanged.RemoveListener(delegate { Refresh();});
        dropdwon_Ratio.onValueChanged.AddListener(delegate {Refresh();});
        dropdwon_Stylize.onValueChanged.RemoveListener(delegate { Refresh();});
        dropdwon_Stylize.onValueChanged.AddListener(delegate {Refresh();});


        //TODO

        return true;
    }

    public void initDropdown(TMP_Dropdown dropdown, Dictionary<int, Data.TableData> dict, int Default)
    {
        dropdown.options.Clear();

        List<string> Datas = new List<string>();

        for (int i = 1; i < dict.Count + 1; i++)
        {
            Datas.Add(dict[i].Name);
        }

        foreach (string str in Datas)
        {
            dropdown.options.Add(new TMP_DropdownEX.OptionData(str));
        }

        dropdown.value = Default;

        dropdown.RefreshShownValue();
    }

    public string GetCurrentVersion() { return dropdwon_Version.options[dropdwon_Version.value].text; }
    public string GetCurrentRatio() { return dropdwon_Ratio.options[dropdwon_Ratio.value].text; }
    public string GetCurrentStylize() { return dropdwon_Stylize.options[dropdwon_Stylize.value].text; }

    #region Event
    public void Refresh()
    {
        Debug.Log("Refreshed");
        Managers.UIData.SetFinalSentence();
    }
    #endregion

}
