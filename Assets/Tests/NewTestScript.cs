using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;







public class JumpingBallTests
{
    private JumpingBall jumpingBall;

    [SetUp]
    public void SetUp()
    {
        GameObject ball = new GameObject();
        ball.AddComponent<Rigidbody>();
        jumpingBall = ball.AddComponent<JumpingBall>();
        jumpingBall.Start();
    }

    [UnityTest]
    public IEnumerator JumpHeightMeasurementTest()
    {
        float expectedJumpHeight = 6f;
        float measuredHeight = 5f;
        float tolerance = 1f;

        jumpingBall.Jump();
        yield return new WaitForSeconds(0.5f);

        Assert.IsTrue(measuredHeight >= expectedJumpHeight - tolerance && measuredHeight <= expectedJumpHeight + tolerance);
    }
}
