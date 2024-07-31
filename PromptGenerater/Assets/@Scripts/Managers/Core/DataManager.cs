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

    public Dictionary<int, Data.TableSetData> TableSetDict { get; private set; } = new Dictionary<int, Data.TableSetData>();

    public Dictionary<int, Data.TableData> LayoutDict            { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> PoseDict              { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> AnimalDict            { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> ConceptArtBookDict    { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> MarinLifeDict         { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> PaintArtistDict       { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> RatioDict             { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> StylizeDict           { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> VersionDict           { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> BlankDict             { get; private set; } = new Dictionary<int, Data.TableData>();
    //public Dictionary<int, Data.EnvData> EnvDic               { get; private set; } = new Dictionary<int, Data.EnvData>();

    public void Init()
    {
        TableSetDict         = LoadJson<Data.TableSetDataLoader, int, Data.TableSetData>("TableSetData").MakeDict();

        LayoutDict           = LoadJson<Data.TableDataLoader, int, Data.TableData>("LayoutData"          ).MakeDict();
        PoseDict             = LoadJson<Data.TableDataLoader, int, Data.TableData>("PoseData"            ).MakeDict();
        AnimalDict           = LoadJson<Data.TableDataLoader, int, Data.TableData>("AnimalData"          ).MakeDict();
        ConceptArtBookDict   = LoadJson<Data.TableDataLoader, int, Data.TableData>("ConceptArtBookData"  ).MakeDict();
        MarinLifeDict        = LoadJson<Data.TableDataLoader, int, Data.TableData>("MarinLifeData"       ).MakeDict();
        PaintArtistDict      = LoadJson<Data.TableDataLoader, int, Data.TableData>("PaintArtistData"     ).MakeDict();
        RatioDict            = LoadJson<Data.TableDataLoader, int, Data.TableData>("RatioData"           ).MakeDict();
        StylizeDict          = LoadJson<Data.TableDataLoader, int, Data.TableData>("StylizeData"         ).MakeDict();
        VersionDict          = LoadJson<Data.TableDataLoader, int, Data.TableData>("VersionData"         ).MakeDict();
        BlankDict            = LoadJson<Data.TableDataLoader, int, Data.TableData>("BlankData"           ).MakeDict();
        //EnvDic             = LoadJson<Data.EnvDataLoader, int, Data.EnvData>("EnvData").MakeDict();
        Debug.Log("LoadJson");


        AllDict.Clear();
        AllDict.Add("Layout"            , LayoutDict           );
        AllDict.Add("Pose"              , PoseDict             );
        AllDict.Add("Animal"            , AnimalDict           );
        AllDict.Add("ConceptArtBook"    , ConceptArtBookDict   );
        AllDict.Add("MarinLife"         , MarinLifeDict        );
        AllDict.Add("PaintArtist"       , PaintArtistDict      );
        AllDict.Add("Ratio"             , RatioDict            );
        AllDict.Add("Stylize"           , StylizeDict          );
        AllDict.Add("Version"           , VersionDict          );
        AllDict.Add("Blank"             , BlankDict            );

        Debug.Log("Add Dict to AllDict");
    }

    private Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>(path);
        return JsonConvert.DeserializeObject<Loader>(textAsset.text);
    }
}
