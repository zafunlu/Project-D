using UnityEngine;

public class UnitTestBehaviour : MonoBehaviour
{
    void Start()
    {
        Debug.LogError("This script is only meant for unit testing");
    }

    public static int SimpleCalc(int a)
    {
        return (a * 10 - 7) + a;
    }
}
