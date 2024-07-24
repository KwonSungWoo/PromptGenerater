using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Setting : UI_Scene
{
    enum GameObjects
    {
        None,
    }

    enum Texts
    {
        Setting,
    }

    enum Dropdowns
    {
        Version,
        Ratio,
        Stylize
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));
        BindDropdownEX(typeof(Dropdowns));

        TMP_DropdownEX Version = GetTMP_DropdownEX((int)Dropdowns.Version);
        TMP_DropdownEX Ratio = GetTMP_DropdownEX((int)Dropdowns.Ratio);
        TMP_DropdownEX Stylize = GetTMP_DropdownEX((int)Dropdowns.Stylize);

        Version.initDropdown(Managers.Data.VersionDic, 0);
        Ratio.initDropdown(Managers.Data.RatioDic, 0);
        Stylize.initDropdown(Managers.Data.StylizeDic, 0);



        //TODO



        return true;
    }


}
