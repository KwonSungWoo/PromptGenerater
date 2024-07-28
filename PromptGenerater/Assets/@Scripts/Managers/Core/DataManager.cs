using Data;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<key, value>
{
    Dictionary<key, value> MakeDict();
}

public class DataManager
{
    public Dictionary<string, Dictionary<int, TableData>> AllDict { get; private set; } = new Dictionary<string, Dictionary<int, TableData>>();

    public Dictionary<int, Data.TableSetData> TableSetDic { get; private set; } = new Dictionary<int, Data.TableSetData>();

    public Dictionary<int, Data.TableData> AnimalDic            { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> ConceptArtBookDic    { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> MarinLifeDic         { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> PaintArtistDic       { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> RatioDic             { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> StylizeDic           { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> VersionDic           { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> BlankDic             { get; private set; } = new Dictionary<int, Data.TableData>();
    //public Dictionary<int, Data.EnvData> EnvDic               { get; private set; } = new Dictionary<int, Data.EnvData>();

    public void Init()
    {
        TableSetDic         = LoadJson<Data.TableSetDataLoader, int, Data.TableSetData>("TableSetData").MakeDict();

        AnimalDic           = LoadJson<Data.TableDataLoader, int, Data.TableData>("AnimalData"          ).MakeDict();
        ConceptArtBookDic   = LoadJson<Data.TableDataLoader, int, Data.TableData>("ConceptArtBookData"  ).MakeDict();
        MarinLifeDic        = LoadJson<Data.TableDataLoader, int, Data.TableData>("MarinLifeData"       ).MakeDict();
        PaintArtistDic      = LoadJson<Data.TableDataLoader, int, Data.TableData>("PaintArtistData"     ).MakeDict();
        RatioDic            = LoadJson<Data.TableDataLoader, int, Data.TableData>("RatioData"           ).MakeDict();
        StylizeDic          = LoadJson<Data.TableDataLoader, int, Data.TableData>("StylizeData"         ).MakeDict();
        VersionDic          = LoadJson<Data.TableDataLoader, int, Data.TableData>("VersionData"         ).MakeDict();
        BlankDic            = LoadJson<Data.TableDataLoader, int, Data.TableData>("BlankData"           ).MakeDict();
        //EnvDic            = LoadJson<Data.EnvDataLoader, int, Data.EnvData>("EnvData").MakeDict();


        AllDict.Clear();
        AllDict.Add("Animal"            , AnimalDic           );
        AllDict.Add("ConceptArtBook"    , ConceptArtBookDic   );
        AllDict.Add("MarinLife"         , MarinLifeDic        );
        AllDict.Add("PaintArtist"       , PaintArtistDic      );
        AllDict.Add("Ratio"             , RatioDic            );
        AllDict.Add("Stylize"           , StylizeDic          );
        AllDict.Add("Version"           , VersionDic          );
        AllDict.Add("Blank"             , BlankDic);
    }

    private Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>(path);
        return JsonConvert.DeserializeObject<Loader>(textAsset.text);
    }
}
