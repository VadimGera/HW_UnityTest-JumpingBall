using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assets;



namespace Assets.Tests
{
    public class JumpingBallTests
    {
        [UnityTest]
        public IEnumerator JumpHeightIncreasesAfter0_5Seconds()
        {
            // ������� �����
            GameObject ballObject = new GameObject("Ball");
            ballObject.AddComponent<Rigidbody>();
            JumpingBall jumpingBall = ballObject.AddComponent<JumpingBall>();

            // ���������� ��������� ������ ������
            float initialHeight = ballObject.transform.position.y;

            // �������� ������
            jumpingBall.Jump();

            // ���� 0.5 �������
            yield return new WaitForSeconds(0.5f);

            // �������� ������� ������ ������
            float currentHeight = ballObject.transform.position.y;

            // ���������, ��� ������ ������ ������ ��������� ������
            float jumpHeight = currentHeight - initialHeight;
            Assert.Greater(jumpHeight, 0f);

            // ������� �����
            Object.Destroy(ballObject);
        }
    }
}