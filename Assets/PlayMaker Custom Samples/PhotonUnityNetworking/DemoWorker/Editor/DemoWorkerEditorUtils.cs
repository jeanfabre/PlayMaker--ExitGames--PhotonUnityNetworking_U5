using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

using HutongGames.PlayMakerEditor;

[InitializeOnLoad]
public class DemoWorkerEditorUtils
{

	static bool _eventAdded;


	static string[] _eventList = new string[]{

		"ROOM IS BUSY",
		"ROOM IS EMPTY",
		"CHAT RPC CALL",
		"DOOR RPC CALL"

	};

	static DemoWorkerEditorUtils()
	{
		#if PLAYMAKER_1_9_OR_NEWER
		FsmEditorSettings.ShowNetworkSync = true;
		#endif


		// add global events if needed.
		if (!_eventAdded)
		{
			foreach (string _event in _eventList)
			{
				_eventAdded = PlayMakerUtils.CreateIfNeededGlobalEvent (_event);
			}
		}

	}

}