using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class NewIdea
    {
        [UnityTest]
        public IEnumerator TakePhoto()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/NieuwIdee.unity");
            yield return null;
            
            //TODO check functionality when implemented
        }
        
        [UnityTest]
        public IEnumerator EditPhoto()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/NieuwIdeeEdit.unity");
            yield return null;
            
            //TODO check functionality when implemented
        }
        
        [UnityTest]
        public IEnumerator ConfirmPhoto()
        {
            // Should not be a new scene, should still use 'NieuwIdeeEdit' to show the confirm dialog
            EditorSceneManager.OpenScene("Assets/Scenes/NieuwIdeeEdit.unity");
            yield return null;
            
            //TODO check functionality when implemented
        }
    }
}
