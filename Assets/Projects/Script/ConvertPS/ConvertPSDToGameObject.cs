﻿#if UNITY_EDITOR
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using Sirenix.OdinInspector;
 using Sirenix.OdinInspector.Editor;
 using UnityEditor;
 using UnityEngine;

 namespace ThirdParties.TeamOne.Editor.PsdToGUI
{
    public class ConvertPSDToGameObject : OdinEditorWindow
    {
        [MenuItem("TeamOne/Utilities/Psd To GameObject",priority = 1000)]
        private static void OpenWindow()
        {
            GetWindow<ConvertPSDToGameObject>().Show();
        }
        public Transform drawInObject;
        [FolderPath(RequireExistingPath = true)]
        public string resourceFolder;

        public TextAsset jsonFile;
        private int zIndex = 999;
        [Button]
        private void Generate()
        {
            var layerUis = JsonUtility.FromJson<LayerUi>(jsonFile.text);
            var files = Directory.GetFiles(resourceFolder, "*.png",SearchOption.AllDirectories);
            var spriteData = new List<Object>();
            foreach (var variable in files)
                spriteData.AddRange(AssetDatabase.LoadAllAssetRepresentationsAtPath(variable));
            var spriteList = spriteData.Cast<Sprite>().ToList();
            
            
            for (var i = layerUis.UI.Length - 1; i >= 0; i--)
            {
                var uis = layerUis.UI[i];
                DrawLayer(uis, drawInObject,layerUis.width,layerUis.height, spriteList);
            }
        }


        private void DrawLayer(Layer layer, Transform parent,float screenWidth,float screenHeight, IEnumerable<Sprite> spriteList)
        {
            var obj = new GameObject(layer.name);
            obj.transform.parent = parent;
            obj.transform.localScale = Vector3.one;
            var rectTransform = obj.transform;
            if (layer.type == (int) LayerType.IMAGE)
            {
                rectTransform.localPosition =
                    new Vector3((layer.x - screenWidth / 2)/100f, (layer.y - screenHeight / 2)/100f,zIndex);
                zIndex--;
                var sprite = spriteList.FirstOrDefault(a => a.name.Equals(layer.name.Trim()));
                if (sprite == null)
                    Debug.LogError("Missing file " + layer.name + ".png");
                var image = obj.AddComponent<SpriteRenderer>();
                image.sprite = sprite;
                var size = image.size;
                obj.transform.localScale = new Vector3(layer.width/size.x,layer.height/size.y,1);
            }
            else
            {
                rectTransform.localPosition =
                    new Vector3(0,0);
                if (layer.child == null || layer.child.Count == 0) return;
                for (var index = layer.child.Count - 1; index >= 0; index--)
                {
                    var childLayer = layer.child[index];
                    DrawLayer(childLayer, obj.transform, screenWidth, screenHeight, spriteList);
                }
            }
        }
    }
}
#endif