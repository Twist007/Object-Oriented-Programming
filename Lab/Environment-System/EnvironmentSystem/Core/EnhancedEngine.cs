using System;
using EnvironmentSystem.Interfaces;
using EnvironmentSystem.Models.Objects;

namespace EnvironmentSystem.Core
{
    public class EnhancedEngine : Engine
    {
        private IController controller;
        private bool isPause;

        public EnhancedEngine(int worldWidth,
            int worldHeight, IObjectGenerator<EnvironmentObject> objectGenerator,
            ICollisionHandler collisionHandler,
            IRenderer renderer, IController controller)
             : base(worldWidth, worldHeight, objectGenerator, collisionHandler, renderer)
        {
            this.controller = controller;
            this.AttachControlerEvents();
        }

        private void AttachControlerEvents()
        {
            this.controller.Pause += controller_Pause;
        }

        private void controller_Pause(object sender, EventArgs e)
        {
            this.isPause = !isPause;
        }

        protected override void ExecuteEnvironmentLoop()
        {
            if (!this.isPause)
            {
                base.ExecuteEnvironmentLoop();
            }
        }

        protected override void Insert(EnvironmentObject obj)
        {
            this.controller.ProcessInput();

            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Object cannot be null.");
            }
            base.Insert(obj);
        }
    }
}
