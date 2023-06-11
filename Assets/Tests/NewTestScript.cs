using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class NewTestScript : MonoBehaviour 
{

    [UnityTest]
    public IEnumerator JumpHeightIncreasesAfter0_5Seconds()
    {
        GameObject ballObject = GameObject.Find("Sphere");
        JumpingBall jumpingBall = ballObject.GetComponent<JumpingBall>();

        float initialHeight = ballObject.transform.position.y;

        jumpingBall.Jump();

        yield return new WaitForSeconds(0.5f);

        float currentHeight = ballObject.transform.position.y;
        float jumpHeight = currentHeight - initialHeight;

        Assert.Greater(jumpHeight, 0f);
    }

}
