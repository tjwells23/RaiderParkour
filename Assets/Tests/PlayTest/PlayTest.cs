using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UserMovementTest
{
    [UnityTest]
    public IEnumerator XAxisDirectionTest()
    {
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();
        
        yield return null;
    }

     public IEnumerator ZAxisDirectionTest()
    {
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();
        
        yield return null;
    }

     public IEnumerator JumpTest()
    {
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();
        
        yield return null;
    }

      public IEnumerator CrouchTest()
    {
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();
        
        yield return null;
    }
}
