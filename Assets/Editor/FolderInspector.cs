using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 



public class FolderInspector : AssetPostprocessor
{
       private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,
              string[] movedFromAssetPaths)
       {
              Debug.Log(importedAssets[0]);
              Debug.Log("imported");
              
              
             // throw new NotImplementedException();
       }
}
