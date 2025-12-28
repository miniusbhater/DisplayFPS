using Assets.Scripts.Flight.Demo;
using Assets.Scripts.UI;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Rewired;
using Steamworks;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


namespace DisplayFPS
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private float deltaTime = 0.0f;
        private GUIStyle style;
        void Awake()
        {
            
        }

        void Start()
        {
           
        }
      

        void Update()
        {
         
        }

        void OnGUI()
        {
            if (style == null)
            {
                style = new GUIStyle(GUI.skin.label)
                {
                    fontSize = 20
                };
            }

            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
            int fps = Mathf.RoundToInt(1.0f / deltaTime);

            if (fps < 40) style.normal.textColor = Color.red;
            else if (fps < 60) style.normal.textColor = Color.yellow;
            else style.normal.textColor = Color.green;

            GUI.Label(new Rect(2470, 10, 300, 40), $"{fps} FPS", style);
        }

    }
}



    

