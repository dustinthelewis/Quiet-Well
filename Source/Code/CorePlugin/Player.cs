using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;
using Duality.Components.Physics;

using OpenTK;
using OpenTK.Input;

namespace QuietWell
{
	[Serializable]
    [RequiredComponent(typeof(RigidBody))]
    public class Player : Component, ICmpUpdatable
    {
        void ICmpUpdatable.OnUpdate()
        {
            //Get inputs
            bool left = DualityApp.Keyboard[Key.Left];
            bool right = DualityApp.Keyboard[Key.Right];
            bool up = DualityApp.Keyboard[Key.Up];
            bool down = DualityApp.Keyboard[Key.Down];

            // Convenience variables
            RigidBody body = this.GameObj.RigidBody;
            Vector2 xdir = Vector2.UnitX;
            Vector2 ydir = Vector2.UnitY;

//            if(body.iscollidingwiththe ground)

            if (left)
                body.ApplyLocalForce(xdir * -1.0f * body.Mass);
            else if (right)
                body.ApplyLocalForce(xdir * 1.0f * body.Mass);
            //    else body.LinearVelocity -= body.LinearVelocity * 0.1f * Time.TimeMult;

            if (up)
                body.ApplyLocalImpulse(ydir * -1.0f * body.Mass);
            else if (down)
                body.ApplyLocalForce(ydir * -1.0f * body.Mass);
        }
    }
}
