using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


    public class MenuEditor : Editor
    {
        [MenuItem("Create/ScriptableObject/CreateTextQuestion")]
        public static void CreateTextQuestion()
        {
            CreateInstance("TextQuestion");
        }
    }
