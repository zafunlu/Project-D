using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class MyIdeas
    {
        [SetUp]
        public void ResetScene()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Overzicht.unity");
        }
        
        [Test]
        public void GetIdeas()
        {
            //TODO check functionality when implemented
        }
        
        [UnityTest]
        public IEnumerator NewIdeaButton()
        {
            yield return null;
            
            var newIdeaButtonObj = GameObject.Find("btnNieuwIdee");
            Assert.NotNull(newIdeaButtonObj);

            var newIdeaButton = newIdeaButtonObj.GetComponent<Button>();
            Assert.NotNull(newIdeaButton);
        }
        
        [UnityTest]
        public IEnumerator DeleteIdeaDialog()
        {
            yield return null;
            
            //TODO check functionality when implemented
        }
    }
}
