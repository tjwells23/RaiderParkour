using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DirectionTests
{
    
    [Test]
    public void XPositionTest(){
      var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();

        Assert.NotNull(player);

        var playerOldPosition = new Vector3(0,0,0);
        player.transform.position = playerOldPosition;

        Vector3 targetVelocity = new Vector3(1, 0, 0);
        player.movePlayerXYDirection(targetVelocity);

        var playerFinalPosition = player.transform.position;

        Assert.AreNotEqual(playerOldPosition, playerFinalPosition);
    }


    [Test]
    public void YPositionTest(){
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();

        Assert.NotNull(player);

        var playerOldPosition = new Vector3(0,0,0);
        player.transform.position = playerOldPosition;

        Vector3 targetVelocity = new Vector3(0, 1, 0);
        player.movePlayerXYDirection(targetVelocity);

        var playerFinalPosition = player.transform.position;

        Assert.AreEqual(playerOldPosition, playerFinalPosition);
    }

    [Test]
    public void JumpTest() {
        var gameObj = new GameObject();
        var player = gameObj.AddComponent<FirstPersonController>();

        Assert.NotNull(player);

        var playerOldPosition = new Vector3(0,0,0);
        player.transform.position = playerOldPosition;

        player.Jump();

        Assert.AreEqual(playerOldPosition, player.transform.position);
    }
}


