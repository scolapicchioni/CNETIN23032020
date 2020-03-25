using System;
using System.Collections.Generic;

namespace PhoneLibrary {
    public class Phone {
        public List<App> Apps { get; } = new List<App>();

        public void InstallApp(App app) {
            Apps.Add(app);
            app.Install(this);

        }
    }
}
