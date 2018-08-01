using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEditor;
using UnityEngine;

/// <summary>
/// This is  to force global events
/// </summary>
[ExecuteInEditMode]
public class DemoWorkerSetup : MonoBehaviour {


    static bool _eventCreated;

    static string[] _eventList = new string[]{

        "ROOM IS BUSY",
        "ROOM IS EMPTY",
        "CHAT RPC CALL",
        "DOOR RPC CALL"

    };


    public GameObject WarningCanvas;


    void Update()
    {

#if UNITY_EDITOR
        if (!EditorApplication.isPlaying)
        {
            bool _needsSetup = false;

            foreach(string _event in _eventList)
            {
                _needsSetup = _needsSetup || !FsmEvent.IsEventGlobal(_event);

            }

            if (WarningCanvas != null && WarningCanvas.activeInHierarchy != _needsSetup)
            {
                WarningCanvas.SetActive(_needsSetup);
            }

        }
#endif

    }


}
