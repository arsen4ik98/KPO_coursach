using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewPlayModeTest {

    //[Test]
    //public void NewPlayModeTestSimplePasses()
    //{
    //    playerScripts x = new playerScripts();
    //    Assert.AreEqual(x.transform.Translate(new Vector2(0.0f, x.jump * Time.deltaTime)), x.FixedUpdate);
    //    Assert.AreEqual(x.door.transform.position = new Vector2(-0.06f, -3.88f), x.OnTriggerEnter2D(col.gameObject.tag == "button"));
    //}

    [Test]
    public void NewPlayModeTestPass()
    {
        Assert.Pass();
    }
[Category("Failing Tests;")]
    [Test]
    public void NewPlayModeTestFail()
    {
        Assert.Fail();
    }
    //   [Test]
    //public void NewPlayModeTestSimplePasses1()
    //   {
    //       player2 x = new player2();
        
    //   }
}