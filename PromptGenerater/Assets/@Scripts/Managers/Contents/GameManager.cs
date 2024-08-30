using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameSaveData
{
    public Dictionary<string, string> SrefSaveData;
    public Dictionary<string, string> CrefSaveData;
}

public class GameManager
{

    #region GameData
    GameSaveData _saveData = new GameSaveData();
    public GameSaveData SaveData {  get { return _saveData; } set { _saveData = value; } }
    #endregion

    #region Save & Load
    public string Path { get { return Application.persistentDataPath + "/SaveData.json"; } }
    #endregion

    #region Hero
    private Vector2 _moveDir;
	public Vector2 MoveDir 
	{
		get { return _moveDir;  }

        set 
		{ 
			_moveDir = value;
			OnMoveDirChanged?.Invoke(value);
        }

    }

    private Define.EJoystickState _joystickState;
    public Define.EJoystickState JoystickState
    {
        get { return _joystickState; }
        set 
        {
            _joystickState = value;
            OnJoystickStateChanged?.Invoke(value);
        }
    }
    #endregion 

    #region Action
    public Action<Vector2> OnMoveDirChanged;
	public Action<Define.EJoystickState> OnJoystickStateChanged;
    #endregion

}