
// This file has been generated by the GUI designer. Do not modify.
namespace Launchpad_Launcher
{
	public partial class SettingsDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Entry GameName_entry;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label2;
		private global::Gtk.Entry SystemTarget_entry;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label3;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Entry FTPURL_entry;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label4;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Entry FTPUsername_entry;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label label5;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Entry FTPPassword_entry;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.ProgressBar progressbar3;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Launchpad_Launcher.SettingsDialog
			this.Name = "Launchpad_Launcher.SettingsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Edit Settings");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Launchpad_Launcher.SettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Game Name: ");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GameName_entry = new global::Gtk.Entry ();
			this.GameName_entry.CanFocus = true;
			this.GameName_entry.Name = "GameName_entry";
			this.GameName_entry.IsEditable = true;
			this.GameName_entry.InvisibleChar = '●';
			this.hbox1.Add (this.GameName_entry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GameName_entry]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("System Target: ");
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.SystemTarget_entry = new global::Gtk.Entry ();
			this.SystemTarget_entry.CanFocus = true;
			this.SystemTarget_entry.Name = "SystemTarget_entry";
			this.SystemTarget_entry.IsEditable = true;
			this.SystemTarget_entry.InvisibleChar = '●';
			this.hbox2.Add (this.SystemTarget_entry);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.SystemTarget_entry]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.GtkAlignment2.Add (this.vbox3);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Local</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("FTP URL: ");
			this.hbox3.Add (this.label3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label3]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(37));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.FTPURL_entry = new global::Gtk.Entry ();
			this.FTPURL_entry.CanFocus = true;
			this.FTPURL_entry.Name = "FTPURL_entry";
			this.FTPURL_entry.IsEditable = true;
			this.FTPURL_entry.InvisibleChar = '●';
			this.alignment1.Add (this.FTPURL_entry);
			this.hbox3.Add (this.alignment1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment1]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 1;
			this.vbox4.Add (this.hbox3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox3]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("FTP Username: ");
			this.hbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label4]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.FTPUsername_entry = new global::Gtk.Entry ();
			this.FTPUsername_entry.CanFocus = true;
			this.FTPUsername_entry.Name = "FTPUsername_entry";
			this.FTPUsername_entry.IsEditable = true;
			this.FTPUsername_entry.InvisibleChar = '●';
			this.alignment2.Add (this.FTPUsername_entry);
			this.hbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment2]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 1;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("FTP Password: ");
			this.hbox5.Add (this.label5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label5]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(5));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.FTPPassword_entry = new global::Gtk.Entry ();
			this.FTPPassword_entry.CanFocus = true;
			this.FTPPassword_entry.Name = "FTPPassword_entry";
			this.FTPPassword_entry.IsEditable = true;
			this.FTPPassword_entry.InvisibleChar = '●';
			this.alignment3.Add (this.FTPPassword_entry);
			this.hbox5.Add (this.alignment3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment3]));
			w22.PackType = ((global::Gtk.PackType)(1));
			w22.Position = 1;
			this.vbox4.Add (this.hbox5);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox5]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.GtkAlignment3.Add (this.vbox4);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Remote</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.vbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame2]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.progressbar3 = new global::Gtk.ProgressBar ();
			this.progressbar3.Name = "progressbar3";
			this.alignment4.Add (this.progressbar3);
			w1.Add (this.alignment4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment4]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Internal child Launchpad_Launcher.SettingsDialog.ActionArea
			global::Gtk.HButtonBox w30 = this.ActionArea;
			w30.Name = "dialog1_ActionArea";
			w30.Spacing = 10;
			w30.BorderWidth = ((uint)(5));
			w30.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w30 [this.buttonCancel]));
			w31.Expand = false;
			w31.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w32 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w30 [this.buttonOk]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 345;
			this.DefaultHeight = 294;
			this.Show ();
			this.SystemTarget_entry.Changed += new global::System.EventHandler (this.OnSystemTargetEntryChanged);
			this.FTPURL_entry.Changed += new global::System.EventHandler (this.OnFTPURLEntryChanged);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}