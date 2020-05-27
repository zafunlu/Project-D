using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class LoginScene
    {
        [SetUp]
        public void ResetScene()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
        }

        [UnityTest]
        public IEnumerator LoginSceneComponentsCheck()
        {
            yield return null;
            
            var usernameInputObj = GameObject.Find("inputUsername");
            var passwordInputObj = GameObject.Find("inputPassword");
            var loginBtnObj = GameObject.Find("btnLogin");
            
            // Test objects
            Assert.NotNull(usernameInputObj);
            Assert.NotNull(passwordInputObj);
            Assert.NotNull(loginBtnObj);

            var usernameInput = usernameInputObj.GetComponent<InputField>();
            var passwordInput = passwordInputObj.GetComponent<InputField>();
            var btn = loginBtnObj.GetComponent<Button>();
            
            // Test available components
            Assert.NotNull(usernameInput);
            Assert.NotNull(passwordInput);
            Assert.NotNull(btn);
            
            //TODO check other functionality when implemented
        }
    }
}
