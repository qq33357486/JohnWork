/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{
    public partial class AgentMeta
    {
        private Dictionary<uint, IProperty> _memberProperties = new Dictionary<uint, IProperty>();
        private Dictionary<uint, ICustomizedProperty> _customizedProperties = new Dictionary<uint, ICustomizedProperty>();
        private Dictionary<uint, ICustomizedProperty> _customizedStaticProperties = new Dictionary<uint, ICustomizedProperty>();
        private Dictionary<uint, IInstantiatedVariable> _customizedStaticVars = null;
        private Dictionary<uint, IMethod> _methods = new Dictionary<uint, IMethod>();

        private static Dictionary<uint, AgentMeta> _agentMetas = new Dictionary<uint, AgentMeta>();
        private static Dictionary<string, TypeCreator> _Creators = new Dictionary<string, TypeCreator>();
        private static Dictionary<string, Type> _typesRegistered = new Dictionary<string, Type>();

        public static void Register()
        {
            RegisterBasicTypes();

            registerMeta();
        }

        public static void UnRegister()
        {
            UnRegisterBasicTypes();

            unRegisterMeta();

            _agentMetas.Clear();
            _Creators.Clear();
        }

        public static Type GetTypeFromName(string typeName)
        {
            if (_typesRegistered.ContainsKey(typeName))
            {
                return _typesRegistered[typeName];
            }

            return null;
        }

        static partial void registerMeta();

        static partial void unRegisterMeta();

        public static AgentMeta GetMeta(uint classId)
        {
            if (_agentMetas.ContainsKey(classId))
                return _agentMetas[classId];

            return null;
        }

        public Dictionary<uint, IInstantiatedVariable> InstantiateCustomizedProperties()
        {
            Dictionary<uint, IInstantiatedVariable> vars = new Dictionary<uint, IInstantiatedVariable>();

            //instance customzied properties
            {
                var e = this._customizedProperties.Keys.GetEnumerator();
                while (e.MoveNext())
                {
                    uint id = e.Current;
                    ICustomizedProperty pCustomProperty = this._customizedProperties[id];

                    vars[id] = pCustomProperty.Instantiate();
                }
            }

            if (_customizedStaticVars == null)
            {
                _customizedStaticVars = new Dictionary<uint, IInstantiatedVariable>();

                var e = this._customizedStaticProperties.Keys.GetEnumerator();
                while (e.MoveNext())
                {
                    uint id = e.Current;
                    ICustomizedProperty pCustomProperty = this._customizedStaticProperties[id];

                    this._customizedStaticVars[id] = pCustomProperty.Instantiate();
                }
            }

            //static customzied properties
            {
                var e = this._customizedStaticVars.Keys.GetEnumerator();
                while (e.MoveNext())
                {
                    uint id = e.Current;
                    IInstantiatedVariable pVar = this._customizedStaticVars[id];

                    vars[id] = pVar; 
                }

            }

            return vars;
        }

        public void RegisterMemberProperty(uint propId, IProperty property)
        {
            _memberProperties[propId] = property;
        }

        public void RegisterCustomizedProperty(uint propId, ICustomizedProperty property)
        {
            _customizedProperties[propId] = property;
        }

        public void RegisterStaticCustomizedProperty(uint propId, ICustomizedProperty property)
        {
            _customizedStaticProperties[propId] = property;
        }

        public void RegisterMethod(uint methodId, IMethod method)
        {
            _methods[methodId] = method;
        }

        public IProperty GetProperty(uint propId)
        {
            if (_customizedStaticProperties.ContainsKey(propId))
                return _customizedStaticProperties[propId];

            if (_customizedProperties.ContainsKey(propId))
                return _customizedProperties[propId];

            if (_memberProperties.ContainsKey(propId))
                return _memberProperties[propId];

            return null;
        }

        public IProperty GetMemberProperty(uint propId)
        {
            if (_memberProperties.ContainsKey(propId))
                return _memberProperties[propId];

            return null;
        }

        public Dictionary<uint, IProperty> GetMemberProperties()
        {
            return _memberProperties;
        }

        public IMethod GetMethod(uint methodId)
        {
            if (_methods.ContainsKey(methodId))
                return _methods[methodId];

            return null;
        }

        class TypeCreator
        {
            public delegate ICustomizedProperty PropertyCreator(uint propId, string propName, string valueStr);
            public delegate ICustomizedProperty ArrayItemPropertyCreator(uint parentId, string parentName);
            public delegate IInstanceMember InstancePropertyCreator(string instance, IInstanceMember indexMember, uint id);
            public delegate IInstanceMember InstanceConstCreator(object value);

            PropertyCreator _propertyCreator;
            ArrayItemPropertyCreator _arrayItemPropertyCreator;
            InstancePropertyCreator _instancePropertyCreator;
            InstanceConstCreator _instanceConstCreator;

            public TypeCreator(PropertyCreator propCreator, ArrayItemPropertyCreator arrayItemPropCreator, InstancePropertyCreator instancePropertyCreator, InstanceConstCreator instanceConstCreator)
            {
                _propertyCreator = propCreator;
                _arrayItemPropertyCreator = arrayItemPropCreator;
                _instancePropertyCreator = instancePropertyCreator;
                _instanceConstCreator = instanceConstCreator;
            }

            public ICustomizedProperty CreateProperty(uint propId, string propName, string valueStr)
            {
                return _propertyCreator(propId, propName, valueStr);
            }

            public ICustomizedProperty CreateArrayItemProperty(uint parentId, string parentName)
            {
                return _arrayItemPropertyCreator(parentId, parentName);
            }

            public IInstanceMember CreateInstanceProperty(string instance, IInstanceMember indexMember, uint id)
            {
                return _instancePropertyCreator(instance, indexMember, id);
            }

            public IInstanceMember CreateInstanceConst(object value)
            {
                return _instanceConstCreator(value);
            }
        }

        public static ICustomizedProperty CreateProperty(string typeName, uint propId, string propName, string valueStr)
        {
            if (_Creators.ContainsKey(typeName))
            {
                TypeCreator creator = _Creators[typeName];
                return creator.CreateProperty(propId, propName, valueStr);
            }

            Debug.Check(false);
            return null;
        }

        public static ICustomizedProperty CreateArrayItemProperty(string typeName, uint parentId, string parentName)
        {
            if (_Creators.ContainsKey(typeName))
            {
                TypeCreator creator = _Creators[typeName];
                return creator.CreateArrayItemProperty(parentId, parentName);
            }

            Debug.Check(false);
            return null;
        }

        public static IInstanceMember CreateInstanceProperty(string typeName, string instance, IInstanceMember indexMember, uint varId)
        {
            if (_Creators.ContainsKey(typeName))
            {
                TypeCreator creator = _Creators[typeName];
                return creator.CreateInstanceProperty(instance, indexMember, varId);
            }

            Debug.Check(false);
            return null;
        }

        public static IInstanceMember CreateInstanceConst(string typeName, string valueStr)
        {
            if (_Creators.ContainsKey(typeName))
            {
                TypeCreator creator = _Creators[typeName];
                object value = ParseTypeValue(typeName, valueStr);

                return creator.CreateInstanceConst(value);
            }

            Debug.Check(false);
            return null;
        }

        private static object ParseTypeValue(string typeName, string valueStr)
        {
            bool bArrayType = false;
            Type type = Utils.GetTypeFromName(typeName, ref bArrayType);
            Debug.Check(type != null);

            if (bArrayType || !Utils.IsRefNullType(type))
            {
                if (!string.IsNullOrEmpty(valueStr))
                {
                    return StringUtils.FromString(type, valueStr, bArrayType);
                }
                else if (type == typeof(string))
                {
                    return string.Empty;
                }
            }

            return null;
        }

        public static string ParseInstanceNameProperty(string fullName, ref string instanceName, ref string agentType)
        {
            //Self.AgentActionTest::Action2(0)
            int pClassBegin = fullName.IndexOf('.');

            if (pClassBegin != -1)
            {
                instanceName = fullName.Substring(0, pClassBegin).Replace("::", ".");

                string propertyName = fullName.Substring(pClassBegin + 1);
                int variableEnd = propertyName.LastIndexOf(':');
                Debug.Check(variableEnd != -1);

                agentType = propertyName.Substring(0, variableEnd - 1).Replace("::", ".");
                string variableName = propertyName.Substring(variableEnd + 1);
                return variableName;
            }

            return fullName;
        }

        public static ICustomizedProperty CreatorProperty<T>(uint propId, string propName, string valueStr)
        {
            return new CCustomizedProperty<T>(propId, propName, valueStr);
        }

        public static ICustomizedProperty CreatorArrayItemProperty<T>(uint parentId, string parentName)
        {
            return new CCustomizedArrayItemProperty<T>(parentId, parentName);
        }

        public static IInstanceMember CreatorInstanceProperty<T>(string instance, IInstanceMember indexMember, uint varId)
        {
            return new CInstanceCustomizedProperty<T>(instance, indexMember, varId);
        }

        public static IInstanceMember CreatorInstanceConst<T>(object value)
        {
            return new CInstanceConst<T>(value);
        }

        public static bool Register<T>(string typeName)
        {
            TypeCreator tc = new TypeCreator(CreatorProperty<T>, CreatorArrayItemProperty<T>, CreatorInstanceProperty<T>, CreatorInstanceConst<T>);
            _Creators[typeName] = tc;

            string vectorTypeName = string.Format("vector<{0}>", typeName);
            TypeCreator tcl = new TypeCreator(CreatorProperty<List<T>>, CreatorArrayItemProperty<List<T>>, CreatorInstanceProperty<List<T>>, CreatorInstanceConst<List<T>>);
            _Creators[vectorTypeName] = tcl;

            _typesRegistered[typeName] = typeof(T);

            return true;
        }

        public static void UnRegister<T>(string typeName)
        {
            _typesRegistered.Remove(typeName);

            _Creators.Remove(typeName);

            string vectorTypeName = string.Format("vector<{0}>", typeName);
            _Creators.Remove(vectorTypeName);
        }

        private static void RegisterBasicTypes()
        {
            Register<bool>("bool");
            Register<Boolean>("Boolean");
            Register<byte>("byte");
            Register<byte>("ubyte");
            Register<Byte>("Byte");
            Register<char>("char");
            Register<Char>("Char");
            Register<decimal>("decimal");
            Register<Decimal>("Decimal");
            Register<double>("double");
            Register<Double>("Double");
            Register<float>("float");
            Register<int>("int");
            Register<Int16>("Int16");
            Register<Int32>("Int32");
            Register<Int64>("Int64");
            Register<long>("long");
            Register<long>("llong");

            Register<sbyte>("sbyte");
            Register<SByte>("SByte");
            Register<short>("short");
            Register<ushort>("ushort");

            Register<uint>("uint");
            Register<UInt16>("UInt16");
            Register<UInt32>("UInt32");
            Register<UInt64>("UInt64");
            Register<ulong>("ulong");
            Register<ulong>("ullong");
            Register<Single>("Single");
            Register<string>("string");
            Register<String>("String");
            Register<object>("object");
            Register<UnityEngine.GameObject>("UnityEngine.GameObject");
            Register<UnityEngine.Vector2>("UnityEngine.Vector2");
            Register<UnityEngine.Vector3>("UnityEngine.Vector3");
            Register<UnityEngine.Vector4>("UnityEngine.Vector4");
            Register<behaviac.Agent>("behaviac.Agent");
            Register<behaviac.EBTStatus>("behaviac.EBTStatus");
        }

        private static void UnRegisterBasicTypes()
        {
            UnRegister<bool>("bool");
            UnRegister<Boolean>("Boolean");
            UnRegister<byte>("byte");
            UnRegister<byte>("ubyte");
            UnRegister<Byte>("Byte");
            UnRegister<char>("char");
            UnRegister<Char>("Char");
            UnRegister<decimal>("decimal");
            UnRegister<Decimal>("Decimal");
            UnRegister<double>("double");
            UnRegister<Double>("Double");
            UnRegister<float>("float");
            UnRegister<Single>("Single");
            UnRegister<int>("int");
            UnRegister<Int16>("Int16");
            UnRegister<Int32>("Int32");
            UnRegister<Int64>("Int64");
            UnRegister<long>("long");
            UnRegister<long>("llong");
            UnRegister<sbyte>("sbyte");
            UnRegister<SByte>("SByte");
            UnRegister<short>("short");
            UnRegister<ushort>("ushort");

            UnRegister<uint>("uint");
            UnRegister<UInt16>("UInt16");
            UnRegister<UInt32>("UInt32");
            UnRegister<UInt64>("UInt64");
            UnRegister<ulong>("ulong");
            UnRegister<ulong>("ullong");

            UnRegister<string>("string");
            UnRegister<String>("String");
            UnRegister<object>("object");
            UnRegister<UnityEngine.GameObject>("UnityEngine.GameObject");
            UnRegister<UnityEngine.Vector2>("UnityEngine.Vector2");
            UnRegister<UnityEngine.Vector3>("UnityEngine.Vector3");
            UnRegister<UnityEngine.Vector4>("UnityEngine.Vector4");
            UnRegister<behaviac.Agent>("behaviac.Agent");
            UnRegister<behaviac.EBTStatus>("behaviac.EBTStatus");
        }

        public static IInstanceMember ParseProperty<T>(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return null;

                List<string> tokens = StringUtils.SplitTokens(value);

                // const
                if (tokens.Count == 1)
                {
                    string typeName = Utils.GetNativeTypeName(typeof(T));

                    return AgentMeta.CreateInstanceConst(typeName, value);
                }

                return ParseProperty(value);
            }
            catch (System.Exception e)
            {
                Debug.Check(false, e.Message);
            }

            return null;
        }

        public static IInstanceMember ParseProperty(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return null;

                List<string> tokens = StringUtils.SplitTokens(value);
                string typeName = "";

                if (tokens[0] == "const")
                {
                    // const Int32 0
                    Debug.Check(tokens.Count == 3);

                    const int kConstLength = 5;
                    string strRemaining = value.Substring(kConstLength + 1);
                    int p = StringUtils.FirstToken(strRemaining, ' ', ref typeName);

                    typeName = typeName.Replace("::", ".");

                    string strVale = strRemaining.Substring(p + 1);

                    // const
                    return AgentMeta.CreateInstanceConst(typeName, strVale);
                }
                else
                {
                    string propStr = "";
                    string indexPropStr = "";

                    if (tokens[0] == "static")
                    {
                        // static float Self.AgentNodeTest::s_float_type_0
                        // static float Self.AgentNodeTest::s_float_type_0[int Self.AgentNodeTest::par_int_type_2]
                        Debug.Check(tokens.Count == 3 || tokens.Count == 4);

                        typeName = tokens[1];
                        propStr = tokens[2];
                        if (tokens.Count == 4) // array index
                        {
                            indexPropStr = tokens[3];
                        }
                    }
                    else
                    {
                        // float Self.AgentNodeTest::par_float_type_1
                        // float Self.AgentNodeTest::par_float_type_1[int Self.AgentNodeTest::par_int_type_2]
                        Debug.Check(tokens.Count == 2 || tokens.Count == 3);

                        typeName = tokens[0];
                        propStr = tokens[1];
                        if (tokens.Count == 3) // array index
                        {
                            indexPropStr = tokens[2];
                        }
                    }

                    string arrayItem = "";
                    IInstanceMember indexMember = null;
                    if (!string.IsNullOrEmpty(indexPropStr))
                    {
                        arrayItem = "[]";
                        indexMember = ParseProperty<int>(indexPropStr);
                    }

                    typeName = typeName.Replace("::", ".");
                    propStr = propStr.Replace("::", ".");

                    string[] props = propStr.Split('.');
                    Debug.Check(props.Length >= 3);

                    string instantceName = props[0];
                    string propName = props[props.Length - 1];
                    string className = props[1];

                    for (int i = 2; i < props.Length - 1; ++i)
                    {
                        className += "." + props[i];
                    }

                    uint classId = Utils.MakeVariableId(className);
                    AgentMeta meta = AgentMeta.GetMeta(classId);
                    Debug.Check(meta != null, "please add the exported 'AgentProperties.cs' and 'customizedtypes.cs' into the project!");

                    uint propId = Utils.MakeVariableId(propName + arrayItem);

                    // property
                    IProperty p = meta.GetProperty(propId);
                    if (p != null)
                    {
                        return p.CreateInstance(instantceName, indexMember);
                    }

                    // local var
                    return AgentMeta.CreateInstanceProperty(typeName, instantceName, indexMember, propId);
                }
            }
            catch (System.Exception e)
            {
                Debug.Check(false, e.Message);
            }

            return null;
        }

        public static IMethod ParseMethod(string valueStr, ref string methodName)
        {
            //Self.test_ns::AgentActionTest::Action2(0)
            if (string.IsNullOrEmpty(valueStr) || (valueStr[0] == '\"' && valueStr[1] == '\"'))
            {
                return null;
            }

            string agentIntanceName = null;
            string agentClassName = null;
            int pBeginP = ParseMethodNames(valueStr, ref agentIntanceName, ref agentClassName, ref methodName);

            uint agentClassId = Utils.MakeVariableId(agentClassName);
            uint methodId = Utils.MakeVariableId(methodName);

            AgentMeta meta = AgentMeta.GetMeta(agentClassId);
            Debug.Check(meta != null);

            IMethod method = meta.GetMethod(methodId);

            if (method == null)
            {
                Debug.Check(false, string.Format("Method of {0}::{1} is not registered!\n", agentClassName, methodName));
            }
            else
            {
                method = (IMethod)(method.Clone());

                string paramsStr = valueStr.Substring(pBeginP);
                Debug.Check(paramsStr[0] == '(');

                List<string> paramsTokens = new List<string>();
                int len = paramsStr.Length;
                Debug.Check(paramsStr[len - 1] == ')');

                string text = paramsStr.Substring(1, len - 2);
                paramsTokens = ParseForParams(text);

                method.Load(agentIntanceName, paramsTokens.ToArray());
            }

            return method;
        }

        public static IMethod ParseMethod(string valueStr)
        {
            string methodName = "";
            return ParseMethod(valueStr, ref methodName);
        }

        private static int ParseMethodNames(string fullName, ref string agentIntanceName, ref string agentClassName, ref string methodName)
        {
            //Self.test_ns::AgentActionTest::Action2(0)
            int pClassBegin = fullName.IndexOf('.');
            Debug.Check(pClassBegin != -1);

            agentIntanceName = fullName.Substring(0, pClassBegin);

            int pBeginAgentClass = pClassBegin + 1;

            int pBeginP = fullName.IndexOf('(', pBeginAgentClass);
            Debug.Check(pBeginP != -1);

            //test_ns::AgentActionTest::Action2(0)
            int pBeginMethod = fullName.LastIndexOf(':', pBeginP);
            Debug.Check(pBeginMethod != -1);
            //skip '::'
            Debug.Check(fullName[pBeginMethod] == ':' && fullName[pBeginMethod - 1] == ':');
            pBeginMethod += 1;

            int pos1 = pBeginP - pBeginMethod;

            methodName = fullName.Substring(pBeginMethod, pos1);

            int pos = pBeginMethod - 2 - pBeginAgentClass;

            agentClassName = fullName.Substring(pBeginAgentClass, pos).Replace("::", ".");

            return pBeginP;
        }

        //suppose params are seprated by ','
        private static List<string> ParseForParams(string tsrc)
        {
            int tsrcLen = tsrc.Length;
            int startIndex = 0;
            int index = 0;
            int quoteDepth = 0;

            List<string> params_ = new List<string>();

            for (; index < tsrcLen; ++index)
            {
                if (tsrc[index] == '"')
                {
                    quoteDepth++;

                    if ((quoteDepth & 0x1) == 0)
                    {
                        //closing quote
                        quoteDepth -= 2;
                        Debug.Check(quoteDepth >= 0);
                    }
                }
                else if (quoteDepth == 0 && tsrc[index] == ',')
                {
                    //skip ',' inside quotes, like "count, count"
                    int lengthTemp = index - startIndex;
                    string strTemp = tsrc.Substring(startIndex, lengthTemp);
                    params_.Add(strTemp);
                    startIndex = index + 1;
                }
            }//end for

            // the last param
            int lengthTemp0 = index - startIndex;

            if (lengthTemp0 > 0)
            {
                string strTemp = tsrc.Substring(startIndex, lengthTemp0);
                params_.Add(strTemp);
            }

            return params_;
        }
    }

}//namespace behaviac
