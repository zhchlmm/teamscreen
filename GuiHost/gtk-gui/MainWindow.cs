
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Entry SystemId;

	private global::Gtk.Entry Password;

	private global::Gtk.Button btnSave;

	private global::Gtk.Label lblStatus;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.SystemId = new global::Gtk.Entry();
		this.SystemId.CanFocus = true;
		this.SystemId.Name = "SystemId";
		this.SystemId.IsEditable = false;
		this.SystemId.InvisibleChar = '•';
		this.hbox1.Add(this.SystemId);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.SystemId]));
		w1.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Password = new global::Gtk.Entry();
		this.Password.CanFocus = true;
		this.Password.Name = "Password";
		this.Password.IsEditable = true;
		this.Password.InvisibleChar = '•';
		this.hbox1.Add(this.Password);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Password]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnSave = new global::Gtk.Button();
		this.btnSave.CanFocus = true;
		this.btnSave.Name = "btnSave";
		this.btnSave.UseUnderline = true;
		this.btnSave.Label = global::Mono.Unix.Catalog.GetString("Speichern");
		this.hbox1.Add(this.btnSave);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnSave]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.lblStatus = new global::Gtk.Label();
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Status");
		this.vbox1.Add(this.lblStatus);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblStatus]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 410;
		this.DefaultHeight = 163;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnSave.Clicked += new global::System.EventHandler(this.OnBtnSaveClicked);
	}
}
