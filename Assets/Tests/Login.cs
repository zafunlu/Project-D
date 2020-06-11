using System;
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
        public IEnumerator LoginComponentsCheck()
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

        [Test]
        public void namePasswordMatchTest1()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsTrue(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest2()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "tESTnaam1";
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsTrue(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest3()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam2";
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest4()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = "TESTpw123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest5()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = "testpw123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest6()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = "foutje";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest7()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "foutnaam";
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest8()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = null;
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest9()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = null;
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest10()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = "testPW123";
            List<Tuple<string, string>> mockdb = null;

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest11()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = null;
            string password = "testPW123";
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>(null, "testPW123"), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }

        [Test]
        public void namePasswordMatchTest12()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Login.unity");
            LoginUIscript script = GameObject.Find("Canvas").GetComponent<LoginUIscript>();

            string username = "Testnaam1";
            string password = null;
            var mockdb = new List<Tuple<string, string>> { new Tuple<string, string>("Testnaam1", null), new Tuple<string, string>("Testnaam2", "TESTpw123") };

            Assert.IsFalse(script.namePasswordMatch(username, password, mockdb));
        }
    }
}
