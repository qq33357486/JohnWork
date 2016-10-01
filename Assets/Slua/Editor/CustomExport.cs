// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"); to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace SLua
{
    using System.Collections.Generic;
    using System;
    using FairyGUI;

    public class CustomExport
    {
        public static void OnGetAssemblyToGenerateExtensionMethod(out List<string> list)
        {
            list = new List<string> {
                "Assembly-CSharp",
            };
        }

        public static void OnAddCustomClass(LuaCodeGen.ExportGenericDelegate add)
        {
            add(typeof(System.Func<int>), null);
            add(typeof(System.Action<int, string>), null);
            add(typeof(System.Action<int, Dictionary<int, object>>), null);
            add(typeof(List<int>), "ListInt");
            add(typeof(Dictionary<int, string>), "DictIntStr");
            add(typeof(string), "String");

            #region fairyGUI

            //add(typeof(EventContext), "EventContext");

            //add(typeof(EventDispatcher), "EventDispatcher");
            //add(typeof(EventListener), "EventListener");
            //add(typeof(InputEvent), "InputEvent");
            //add(typeof(DisplayObject), "DisplayObject");
            //add(typeof(Container), "Container");
            //add(typeof(Stage), "Stage");
            //add(typeof(Controller), "Controller");
            //add(typeof(GObject), "GObject");
            //add(typeof(GGraph), "GGraph");
            //add(typeof(GGroup), "GGroup");
            //add(typeof(GImage), "GImage");
            //add(typeof(GLoader), "GLoader");
            //add(typeof(PlayState), "PlayState");
            //add(typeof(GMovieClip), "GMovieClip");
            //add(typeof(TextFormat), "TextFormat");
            //add(typeof(GTextField), "GTextField");
            //add(typeof(GRichTextField), "GRichTextField");
            //add(typeof(GTextInput), "GTextInput");
            //add(typeof(GComponent), "GComponent");
            //add(typeof(GList), "GList");
            //add(typeof(GRoot), "GRoot");
            //add(typeof(GLabel), "GLabel");
            //add(typeof(GButton), "GButton");
            //add(typeof(GComboBox), "GComboBox");
            //add(typeof(GProgressBar), "GProgressBar");
            //add(typeof(GSlider), "GSlider");
            //add(typeof(PopupMenu), "PopupMenu");
            //add(typeof(ScrollPane), "ScrollPane");
            //add(typeof(Transition), "Transition");
            //add(typeof(UIPackage), "UIPackage");
            //add(typeof(Window), "Window");
            //add(typeof(GObjectPool), "GObjectPool");
            //add(typeof(Relations), "Relations");
            //add(typeof(RelationType), "RelationType");
            //add(typeof(Timers), "Timers");
            //add(typeof(LuaUIHelper), "");
            //add(typeof(GLuaComponent), "");
            //add(typeof(GLuaLabel), "");
            //add(typeof(GLuaButton), "");
            //add(typeof(GLuaProgressBar), "");
            //add(typeof(GLuaSlider), "");
            //add(typeof(GLuaComboBox), "");
            //add(typeof(LuaWindow), "");
            //add(typeof(TweenUtils), "");
            #endregion
            // add your custom class here
            // add( type, typename)
            // type is what you want to export
            // typename used for simplify generic type name or rename, like List<int> named to "ListInt", if not a generic type keep typename as null or rename as new type name
        }

        public static void OnAddCustomAssembly(ref List<string> list)
        {
            // add your custom assembly here
            // you can build a dll for 3rd library like ngui titled assembly name "NGUI", put it in Assets folder
            // add its name into list, slua will generate all exported interface automatically for you

            //list.Add("NGUI");
            list.Add("FairyGUI");
        }

        public static HashSet<string> OnAddCustomNamespace()
        {
            return new HashSet<string>
            {
                //"NLuaTest.Mock"
                "DJLuaTools"
            };
        }

        // if uselist return a white list, don't check noUseList(black list) again
        public static void OnGetUseList(out List<string> list)
        {
            list = new List<string>
            {
                //"UnityEngine.GameObject",
            };
        }

        public static List<string> FunctionFilterList = new List<string>()
        {
            "UIWidget.showHandles",
            "UIWidget.showHandlesWithMoveTool",
        };
        // black list if white list not given
        public static void OnGetNoUseList(out List<string> list)
        {
            list = new List<string>
        {
            "HideInInspector",
            "ExecuteInEditMode",
            "AddComponentMenu",
            "ContextMenu",
            "RequireComponent",
            "DisallowMultipleComponent",
            "SerializeField",
            "AssemblyIsEditorAssembly",
            "Attribute",
            "Types",
            "UnitySurrogateSelector",
            "TrackedReference",
            "TypeInferenceRules",
            "FFTWindow",
            "RPC",
            "Network",
            "MasterServer",
            "BitStream",
            "HostData",
            "ConnectionTesterStatus",
            "GUI",
            "EventType",
            "EventModifiers",
            "FontStyle",
            "TextAlignment",
            "TextEditor",
            "TextEditorDblClickSnapping",
            "TextGenerator",
            "TextClipping",
            "Gizmos",
             "ADBannerView",
            "ADInterstitialAd",
            "Android",
            "Tizen",
            "jvalue",
            "iPhone",
            "iOS",
            "CalendarIdentifier",
            "CalendarUnit",
            "CalendarUnit",
            "ClusterInput",
            "FullScreenMovieControlMode",
            "FullScreenMovieScalingMode",
            "Handheld",
            "LocalNotification",
            "NotificationServices",
            "RemoteNotificationType",
            "RemoteNotification",
            "SamsungTV",
            "TextureCompressionQuality",
            "TouchScreenKeyboardType",
            "TouchScreenKeyboard",
            "MovieTexture",
            "UnityEngineInternal",
            "Terrain",
            "Tree",
            "SplatPrototype",
            "DetailPrototype",
            "DetailRenderMode",
            "MeshSubsetCombineUtility",
            "AOT",
            "Social",
            "Enumerator",
            "SendMouseEvents",
            "Cursor",
            "Flash",
            "ActionScript",
            "OnRequestRebuild",
            "Ping",
            "ShaderVariantCollection",
            "SimpleJson.Reflection",
            "CoroutineTween",
            "GraphicRebuildTracker",
            "Advertisements",
            "UnityEditor",
            "Apple",
        };
        }

    }
}