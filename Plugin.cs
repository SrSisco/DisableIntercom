
using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;
namespace DisableIntercom
{

    public class Plugin : Plugin<Config>
    {
        private EventHandlers EventHandler;
        public override string Name => "DisableIntercom";
        public override string Author => "SrSisco#2995";
        public override Version Version => new Version(1, 0, 0);
        
        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);

            Player.IntercomSpeaking += EventHandler.OnIntercomSpeaking;
            Log.Info("DisableIntercom has been enabled.");
            base.OnEnabled();

        }

        public override void OnDisabled()
        {
            Player.IntercomSpeaking -= EventHandler.OnIntercomSpeaking;
            EventHandler = null;
            Log.Info("DisableIntercom has been disabled.");
            base.OnDisabled();
        }
    }
}
