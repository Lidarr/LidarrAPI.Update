using System;
using NLog;
using NLog.Config;
using NLog.Targets;
using SharpRaven;
using SharpRaven.Data;

namespace LidarrAPI.Log
{
    [Target("Sentry")]
    public sealed class SentryTarget : TargetWithLayout
    {
        public SentryTarget()
        {
        }

        [RequiredParameter]
        public string Dsn {get; set;}

        protected override void Write(LogEventInfo logEvent)
        {
            var message = this.Layout.Render(logEvent);
            var client = new RavenClient(this.Dsn);
            client.Capture(new SentryEvent(message));
        }

    }
}