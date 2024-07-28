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

    private string Option_Sentence_Head;
    private string Option_Sentence_Tail;
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

    private void Start()
    {
        Dropdown_AttributeOfTable.onValueChanged.RemoveListener(delegate { Refresh(); });
        Dropdown_AttributeOfTable.onValueChanged.AddListener(delegate { Refresh(); });
        Dropdown_TableName.onValueChanged.RemoveListener(delegate { ResetChild(); });
        Dropdown_TableName.onValueChanged.AddListener(delegate { ResetChild(); });
        Dropdown_TableName.onValueChanged.RemoveListener(delegate { SetTableNameSentence(); });
        Dropdown_TableName.onValueChanged.AddListener(delegate { SetTableNameSentence(); });
        Dropdown_TableName.onValueChanged.RemoveListener(delegate { Refresh(); });
        Dropdown_TableName.onValueChanged.AddListener(delegate { Refresh(); });
    }

    public void SetTableName(string name)
    {
    }

    public string GetTableName()
    {
        return Dropdown_TableName.options[Dropdown_TableName.value].text;
    }

    public void SetTableNameSentence()
    {
        Managers.Data.TableSetDic.TryGetValue(Dropdown_TableName.value + 1, out TableSetData data);
        Option_Sentence_Head = data.Scentence_Head;
        Option_Sentence_Tail = data.Scentence_Tail;
    }

    public string GetTableNameSentenceHead()
    {
        return Option_Sentence_Head;
    }

    public string GetTableNameSentenceTail()
    {
        return Option_Sentence_Tail;
    }

    public void SetAttributeOfTable(int value)
    {
        Dropdown_AttributeOfTable.value = value;
    }

    public string GetAttributeOfTable()
    {
        return Dropdown_AttributeOfTable.options[Dropdown_AttributeOfTable.value].text;
    }

    private void ResetChild()
    {
        initDropdown(Dropdown_AttributeOfTable, SelectDic(Dropdown_TableName), 0);
    }
}
