﻿namespace Apex.AI.Teaching
{
    using UnityEngine;

    public sealed class MyPathBlasterUnit : BlasterUnit
    {
        public override bool isMoving
        {
            get { return base.isMoving; }
        }

        public override void MoveTo(Vector3 destination)
        {
            base.MoveTo(destination);
        }

        public override void RandomWander()
        {
            base.RandomWander();
        }

        public override void StopMoving()
        {
            base.StopMoving();
        }
    }
}