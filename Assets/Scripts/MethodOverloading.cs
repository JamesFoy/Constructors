using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloading : MonoBehaviour
{
    public int Calculate(int x, int y)
    {
        int z;
        z = x + y;
        Debug.Log(" " + x + " + " + y + " = " + z);
        return z;
    }

    public int Calculate(int z)
    {
        int f;
        f = z + 100;
        Debug.Log(" " + z + " + " + "100 = " + f);
        return f;
    }
}
