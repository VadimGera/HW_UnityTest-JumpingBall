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
            // Создаем шарик
            GameObject ballObject = new GameObject("Ball");
            ballObject.AddComponent<Rigidbody>();
            JumpingBall jumpingBall = ballObject.AddComponent<JumpingBall>();

            // Запоминаем начальную высоту шарика
            float initialHeight = ballObject.transform.position.y;

            // Вызываем прыжок
            jumpingBall.Jump();

            // Ждем 0.5 секунды
            yield return new WaitForSeconds(0.5f);

            // Получаем текущую высоту шарика
            float currentHeight = ballObject.transform.position.y;

            // Проверяем, что высота прыжка больше начальной высоты
            float jumpHeight = currentHeight - initialHeight;
            Assert.Greater(jumpHeight, 0f);

            // Удаляем шарик
            Object.Destroy(ballObject);
        }
    }
}