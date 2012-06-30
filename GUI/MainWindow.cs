using System;
using Gtk;
using KFly.Communication;

public partial class MainWindow: Gtk.Window, ITelemetrySubscriber
{

	private TelemetryLink _tel;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		_tel = new TelemetryLink(this);
		ListStore store = new ListStore(typeof(string));
		string[] ports = _tel.GetAvailablePorts();
		store.AppendValues(ports);
		CB_ports.Model = store;
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}	

	protected void OnCBPortsChanged (object sender, EventArgs e)
	{
		throw new System.NotImplementedException ();
	}




}
