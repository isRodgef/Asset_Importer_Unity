using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class AssetController : AssetPostprocessor
{
       private void OnPreprocessAsset()
       {
             // AssetModifier 
              Debug.Log("rodger is awesome sauce");
              ///throw new NotImplementedException();
       }







       private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,
              string[] movedFromAssetPaths)
       {
        
              /*
              Debug.Log("\nimported assets\n");
              for (int i = 0; i < importedAssets.Length; i++)
              {
                     Debug.Log(importedAssets[i] + "\n");      
              }
             
              Debug.Log("\n********\n");
              
              Debug.Log("\ndeleted assets\n");
              for (int i = 0; i < deletedAssets.Length; i++)
              {
                     Debug.Log(deletedAssets[i] + "\n");
              }
              
              Debug.Log("\n********\n");

              
              Debug.Log("\nmoved assets\n");
              for (int i = 0; i < movedAssets.Length; i++) 
              {
                  Debug.Log(movedAssets[i] + "\n");                 
              }
              
              Debug.Log("\n********\n");

              Debug.Log("\nmovedAssetPaths\n");
              for (int i = 0; i < movedFromAssetPaths.Length; i++) 
              {
                  Debug.Log(movedFromAssetPaths[i] + "\n");   
              }*/





              // throw new NotImplementedException();
       }
}
