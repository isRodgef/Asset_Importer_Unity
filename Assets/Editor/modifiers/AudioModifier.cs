using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioModifier// : AssetModifier
{

    
    public static void modifyAttributes()
    {
         Debug.Log("Rodger is awesome sauce");
        var importer = new AudioImporter();

        if (importer == null)
        {
            Debug.Log("hope you not entering here");
            return;
        }

        AudioImporterSampleSettings sampleSettings = importer.defaultSampleSettings;
        
        sampleSettings.loadType = AudioClipLoadType.CompressedInMemory;
        sampleSettings.compressionFormat = AudioCompressionFormat.AAC;
        
        importer.defaultSampleSettings = sampleSettings;
        
     //   throw new System.NotImplementedException();
    }
}
