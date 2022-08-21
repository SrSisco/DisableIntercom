using Exiled.Events.EventArgs;


namespace DisableIntercom
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        internal void OnIntercomSpeaking(IntercomSpeakingEventArgs ev)
        {
            ev.IsAllowed = false;
        }
    }
}