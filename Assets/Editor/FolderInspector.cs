using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class FolderInspector : AssetPostprocessor
{
       private void OnPreprocessTexture()
       {
            //  throw new NotImplementedException();
       }

       private void OnPostprocessTexture(Texture2D texture)
       {
       ///       throw new NotImplementedException();
       }

       private void OnPreprocessAudio()
       {
///              throw new NotImplementedException();
       }

       private void OnPostprocessAudio(AudioClip arg)
       {

              /*
              var importer = assetImporter as AudioImporter;

              if (importer == null)
                     return;


              AudioImporterSampleSettings sampleSettings = importer.defaultSampleSettings;


              sampleSettings.loadType = AudioClipLoadType.CompressedInMemory;
              sampleSettings.compressionFormat = AudioCompressionFormat.Vorbis;

              importer.defaultSampleSettings = sampleSettings;



              Debug.Log(arg);
              */
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
