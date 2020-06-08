using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton<T> : MonoBehaviour where T : Component
{
    public static T Instance { get; private set; }
    
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

public class App : Singleton<App>
{
    public GameObject[] loadableObjects;

    private List<SavedARObject> SavedScene;
    
    void Start()
    {
        Debug.Log("Starting App");
        
        SavedScene = new List<SavedARObject>();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SaveObjectsFromARScene()
    {
        var arObjects = GameObject.FindGameObjectsWithTag("ARObject");

        foreach (var arObject in arObjects)
        {
            var parent = arObject.transform.parent;
            if (parent != null)
            {
                Debug.Log(parent.name);
                SavedScene.Add(new SavedARObject(arObject.name, parent.name, arObject.transform.position, arObject.transform.rotation));
            }
        }
    }

    public void LoadObjectsToARScene()
    {
        if (SavedScene.Count == 0) return;
        
        var gridTiles = GameObject.FindGameObjectsWithTag("Spawned");
        SavedScene.ForEach(savedObj =>
        {
            var loadableObj = Array.Find(loadableObjects, obj => obj.name == savedObj.Name);
            
            if (loadableObj != null)
            {
                foreach (var tile in gridTiles)
                {
                    if (savedObj.ParentName == tile.name)
                    {
                        var loadedObj = Instantiate(loadableObj, savedObj.Position, savedObj.Rotation);
                        loadedObj.name = loadableObj.name;
                        loadedObj.tag = "ARObject";
                        loadedObj.transform.SetParent(tile.transform);

                        var td = tile.GetComponent<touchdetection>();
                        td.spawnedO = loadedObj;

                        break;
                    }
                }
            }
        });
    }
}

public class SavedARObject
{
    public string ParentName;
    public string Name;
    public Vector3 Position;
    public Quaternion Rotation;
    
    public SavedARObject(string name, string parentName, Vector3 position, Quaternion rotation)
    {
        Name = name;
        ParentName = parentName;
        Position = position;
        Rotation = rotation;
    }
}
