using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerUnitTest
    {
        public class MockPlayerUnit : IPlayerUnit
        {
            public float Speed { get; set; }
            public Vector3 Position { get; set; }
        }

        [Test]
        public void PlayerUnitMove()
        {
            var unit = new MockPlayerUnit {Speed = 5, Position = Vector3.zero };
            var controller = new PlayerUnitController(unit);
            controller.Move(Vector3.up);
            Assert.AreEqual(new Vector3(0,5F,0),  unit.Position);
        }
    }
}
