using Data;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Option : UI_Base
{
    enum Dropdowns
    {
        Dropdown_TableName,
        Dropdown_AttributeOfTable,
    }

    enum Buttons
    {
        Button_Reload,
        Button_Lock,
        Button_Like,
    }

    public TMP_Dropdown Dropdown_TableName;
    public TMP_Dropdown Dropdown_AttributeOfTable;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButtons(typeof(Buttons));
        BindDropdowns(typeof(Dropdowns));

        Dropdown_TableName = GetTMP_Dropdown((int)Dropdowns.Dropdown_TableName);
        Dropdown_AttributeOfTable = GetTMP_Dropdown((int)Dropdowns.Dropdown_AttributeOfTable);

        //TODO

        return true;
    }

    public string GetTableName(string name)
    {
        return Dropdown_TableName.name;
    }

    public string GetAttributeOfTable(string name)
    {
        return Dropdown_TableName.name;
    }

   //public void ChangeChildOption(TMP_Dropdown parent, TMP_Dropdown child)
   //{
   //
   //    Dictionary<string, Dictionary<int, TableData>> dictionaries = Managers.Data.AllDict;
   //    Dictionary<int, TableData> dictionary;
   //
   //    dictionaries.TryGetValue(parent.options[parent.value].text, out dictionary);
   //
   //    initDropdown(child, dictionary, child.value);
   //
   //    //if (child.options[child.value].text == dictionary[1].Name) 
   //    //{
   //    //    initDropdown(child, dictionary, child.value);
   //    //}
   //    //else
   //    //{
   //    //    initDropdown(child, dictionary, 0);
   //    //}
   //
   //
   //}
}
