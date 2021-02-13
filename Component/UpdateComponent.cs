using System;

namespace UComponent
{
    [EnableUpdate]
    public class UpdateComponent : Component
    {
        public override bool Enable { get; set; } = true;


        public override void Update()
        {
            Entity.Update();
        }
    }
}