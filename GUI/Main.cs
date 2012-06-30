using System;
using Gtk;
using KFly.Communication;


namespace KFly.GUI
{
	class MainClass
	{
	
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}


		public void SetAvailableComPorts(string[] portNames)
		{


		}



	}
}
