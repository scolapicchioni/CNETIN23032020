using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneLibrary {
    public abstract class App {
		public App(string name) {
			this.Name = name;
		}

		private string name;

		public string Name {
			get { return name; }
			set {
				if (value.Length > 20) {
					value = value.Substring(0, 20);
				}
				name = value; 
			}
		}

		public void DoSomething() {
			Install(new Phone());
		}

		public abstract void Install(Phone phone);
    }
}
