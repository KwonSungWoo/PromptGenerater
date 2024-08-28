using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Options : UI_Base
{
    public UI_Option Option_01;
    public UI_Option Option_02;
    public UI_Option Option_03;
    public UI_Option Option_04;
    public UI_Option Option_05;
    public UI_Option Option_06;
    public UI_Option Option_07;
    public UI_Option Option_08;


    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region InitDropDown
        Option_01 = GameObject.Find("Option_01").GetComponent<UI_Option>();
        Option_02 = GameObject.Find("Option_02").GetComponent<UI_Option>();
        Option_03 = GameObject.Find("Option_03").GetComponent<UI_Option>();
        Option_04 = GameObject.Find("Option_04").GetComponent<UI_Option>();
        Option_05 = GameObject.Find("Option_05").GetComponent<UI_Option>();
        Option_06 = GameObject.Find("Option_06").GetComponent<UI_Option>();
        Option_07 = GameObject.Find("Option_07").GetComponent<UI_Option>();
        Option_08 = GameObject.Find("Option_08").GetComponent<UI_Option>();

        Option_01.Init();
        Option_02.Init();
        Option_03.Init();
        Option_04.Init();
        Option_05.Init();
        Option_06.Init();
        Option_07.Init();
        Option_08.Init();

        InitDropdowns();
        #endregion



        return true;
    }

    private void InitDropdowns()
    {
        initDropdown(Option_01.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_01);
        initDropdown(Option_02.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_02);
        initDropdown(Option_03.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_03);
        initDropdown(Option_04.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_04);
        initDropdown(Option_05.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_05);
        initDropdown(Option_06.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_06);
        initDropdown(Option_07.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_07);
        initDropdown(Option_08.Dropdown_TableName, Managers.Data.TableSetDic, DefaultSetting.OPTION_TABLE_08);

        initDropdown(Option_01.Dropdown_AttributeOfTable, SelectDic(Option_01.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_01);
        initDropdown(Option_02.Dropdown_AttributeOfTable, SelectDic(Option_02.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_02);
        initDropdown(Option_03.Dropdown_AttributeOfTable, SelectDic(Option_03.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_03);
        initDropdown(Option_04.Dropdown_AttributeOfTable, SelectDic(Option_04.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_04);
        initDropdown(Option_05.Dropdown_AttributeOfTable, SelectDic(Option_05.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_05);
        initDropdown(Option_06.Dropdown_AttributeOfTable, SelectDic(Option_06.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_06);
        initDropdown(Option_07.Dropdown_AttributeOfTable, SelectDic(Option_07.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_07);
        initDropdown(Option_08.Dropdown_AttributeOfTable, SelectDic(Option_08.Dropdown_TableName), DefaultSetting.OPTION_ATTRIBUTETABLE_08);
    }

    public void SetOptionSentences()
    {
        Option_01.SetTableNameSentence();
        Option_02.SetTableNameSentence();
        Option_03.SetTableNameSentence();
        Option_04.SetTableNameSentence();
        Option_05.SetTableNameSentence();
        Option_06.SetTableNameSentence();
        Option_07.SetTableNameSentence();
        Option_08.SetTableNameSentence();
    }
}
