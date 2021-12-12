namespace USB_Comand
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.TextBox textBox2;
            System.Windows.Forms.TextBox textBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HomeName = new MaterialSkin.Controls.MaterialTabControl();
            this.NameHome = new System.Windows.Forms.TabPage();
            this.UsbName = new System.Windows.Forms.TabPage();
            this.RefreshName = new MaterialSkin.Controls.MaterialButton();
            this.WriteBuferSizeText = new MaterialSkin.Controls.MaterialLabel();
            this.ReadBuferSizeText = new MaterialSkin.Controls.MaterialLabel();
            this.ComandEndText = new MaterialSkin.Controls.MaterialLabel();
            this.DataSpeedName = new MaterialSkin.Controls.MaterialLabel();
            this.ComPortName = new MaterialSkin.Controls.MaterialLabel();
            this.ConectDisconect = new MaterialSkin.Controls.MaterialButton();
            this.WriteBuferSize = new MaterialSkin.Controls.MaterialComboBox();
            this.ReadBuferSize = new MaterialSkin.Controls.MaterialComboBox();
            this.ComandEnd = new MaterialSkin.Controls.MaterialComboBox();
            this.DataSpeed = new MaterialSkin.Controls.MaterialComboBox();
            this.ComPort = new MaterialSkin.Controls.MaterialComboBox();
            this.ComName = new System.Windows.Forms.TabPage();
            this.ModeList = new MaterialSkin.Controls.MaterialComboBox();
            this.restartButon = new MaterialSkin.Controls.MaterialButton();
            this.TextTimeName = new MaterialSkin.Controls.MaterialLabel();
            this.TextReadName = new MaterialSkin.Controls.MaterialLabel();
            this.TextWriteName = new MaterialSkin.Controls.MaterialLabel();
            this.AddToListButon = new MaterialSkin.Controls.MaterialButton();
            this.SendButon = new MaterialSkin.Controls.MaterialButton();
            this.WriteComand = new MaterialSkin.Controls.MaterialTextBox();
            this.OpenName = new System.Windows.Forms.TabPage();
            this.D3Name = new System.Windows.Forms.TabPage();
            this.ExsportName = new System.Windows.Forms.TabPage();
            this.SetingName = new System.Windows.Forms.TabPage();
            this.ModeListTekst = new MaterialSkin.Controls.MaterialLabel();
            this.TimeStampCexBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.LineNumberCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.PauseButton = new MaterialSkin.Controls.MaterialButton();
            this.PlayButton = new MaterialSkin.Controls.MaterialButton();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            this.HomeName.SuspendLayout();
            this.UsbName.SuspendLayout();
            this.ComName.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            textBox1.Location = new System.Drawing.Point(50, 121);
            textBox1.MaximumSize = new System.Drawing.Size(1000, 1000);
            textBox1.MaxLength = 40;
            textBox1.MinimumSize = new System.Drawing.Size(390, 300);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new System.Drawing.Size(390, 500);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            textBox2.Location = new System.Drawing.Point(464, 121);
            textBox2.MaximumSize = new System.Drawing.Size(1000, 1000);
            textBox2.MaxLength = 40;
            textBox2.MinimumSize = new System.Drawing.Size(390, 300);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new System.Drawing.Size(390, 500);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            textBox3.Location = new System.Drawing.Point(874, 121);
            textBox3.MaximumSize = new System.Drawing.Size(100, 1000);
            textBox3.MaxLength = 44;
            textBox3.MinimumSize = new System.Drawing.Size(100, 300);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new System.Drawing.Size(100, 500);
            textBox3.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-3d-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-open-file-under-cursor-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-play-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-search-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-separate-using-a-bar-code-50.png");
            this.imageList1.Images.SetKeyName(6, "icons8-settings-48.png");
            this.imageList1.Images.SetKeyName(7, "icons8-usb-48.png");
            // 
            // HomeName
            // 
            this.HomeName.Controls.Add(this.NameHome);
            this.HomeName.Controls.Add(this.UsbName);
            this.HomeName.Controls.Add(this.ComName);
            this.HomeName.Controls.Add(this.OpenName);
            this.HomeName.Controls.Add(this.D3Name);
            this.HomeName.Controls.Add(this.ExsportName);
            this.HomeName.Controls.Add(this.SetingName);
            this.HomeName.Depth = 0;
            this.HomeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeName.ImageList = this.imageList1;
            this.HomeName.Location = new System.Drawing.Point(0, 0);
            this.HomeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.HomeName.Multiline = true;
            this.HomeName.Name = "HomeName";
            this.HomeName.SelectedIndex = 0;
            this.HomeName.Size = new System.Drawing.Size(1250, 700);
            this.HomeName.TabIndex = 0;
            // 
            // NameHome
            // 
            this.NameHome.ImageKey = "icons8-home-48.png";
            this.NameHome.Location = new System.Drawing.Point(4, 55);
            this.NameHome.Name = "NameHome";
            this.NameHome.Padding = new System.Windows.Forms.Padding(3);
            this.NameHome.Size = new System.Drawing.Size(1242, 641);
            this.NameHome.TabIndex = 0;
            this.NameHome.Text = "   Home";
            this.NameHome.UseVisualStyleBackColor = true;
            // 
            // UsbName
            // 
            this.UsbName.Controls.Add(this.RefreshName);
            this.UsbName.Controls.Add(this.WriteBuferSizeText);
            this.UsbName.Controls.Add(this.ReadBuferSizeText);
            this.UsbName.Controls.Add(this.ComandEndText);
            this.UsbName.Controls.Add(this.DataSpeedName);
            this.UsbName.Controls.Add(this.ComPortName);
            this.UsbName.Controls.Add(this.ConectDisconect);
            this.UsbName.Controls.Add(this.WriteBuferSize);
            this.UsbName.Controls.Add(this.ReadBuferSize);
            this.UsbName.Controls.Add(this.ComandEnd);
            this.UsbName.Controls.Add(this.DataSpeed);
            this.UsbName.Controls.Add(this.ComPort);
            this.UsbName.ImageKey = "icons8-usb-48.png";
            this.UsbName.Location = new System.Drawing.Point(4, 55);
            this.UsbName.Name = "UsbName";
            this.UsbName.Padding = new System.Windows.Forms.Padding(3);
            this.UsbName.Size = new System.Drawing.Size(1242, 641);
            this.UsbName.TabIndex = 1;
            this.UsbName.Text = "USB";
            this.UsbName.UseVisualStyleBackColor = true;
            // 
            // RefreshName
            // 
            this.RefreshName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshName.Depth = 0;
            this.RefreshName.DrawShadows = true;
            this.RefreshName.HighEmphasis = true;
            this.RefreshName.Icon = null;
            this.RefreshName.Location = new System.Drawing.Point(281, 300);
            this.RefreshName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefreshName.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshName.Name = "RefreshName";
            this.RefreshName.Size = new System.Drawing.Size(84, 36);
            this.RefreshName.TabIndex = 12;
            this.RefreshName.Text = "refresh";
            this.RefreshName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RefreshName.UseAccentColor = false;
            this.RefreshName.UseVisualStyleBackColor = true;
            this.RefreshName.Click += new System.EventHandler(this.RefreshName_Click);
            // 
            // WriteBuferSizeText
            // 
            this.WriteBuferSizeText.AutoSize = true;
            this.WriteBuferSizeText.Depth = 0;
            this.WriteBuferSizeText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WriteBuferSizeText.Location = new System.Drawing.Point(326, 242);
            this.WriteBuferSizeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.WriteBuferSizeText.Name = "WriteBuferSizeText";
            this.WriteBuferSizeText.Size = new System.Drawing.Size(110, 19);
            this.WriteBuferSizeText.TabIndex = 11;
            this.WriteBuferSizeText.Text = "Write bufer size";
            this.WriteBuferSizeText.Click += new System.EventHandler(this.WriteBuferSizeText_Click);
            // 
            // ReadBuferSizeText
            // 
            this.ReadBuferSizeText.AutoSize = true;
            this.ReadBuferSizeText.Depth = 0;
            this.ReadBuferSizeText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ReadBuferSizeText.Location = new System.Drawing.Point(326, 187);
            this.ReadBuferSizeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReadBuferSizeText.Name = "ReadBuferSizeText";
            this.ReadBuferSizeText.Size = new System.Drawing.Size(110, 19);
            this.ReadBuferSizeText.TabIndex = 10;
            this.ReadBuferSizeText.Text = "Read bufer size";
            this.ReadBuferSizeText.Click += new System.EventHandler(this.ReadBuferSizeText_Click);
            // 
            // ComandEndText
            // 
            this.ComandEndText.AutoSize = true;
            this.ComandEndText.Depth = 0;
            this.ComandEndText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ComandEndText.Location = new System.Drawing.Point(326, 132);
            this.ComandEndText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ComandEndText.Name = "ComandEndText";
            this.ComandEndText.Size = new System.Drawing.Size(91, 19);
            this.ComandEndText.TabIndex = 9;
            this.ComandEndText.Text = "Comand end";
            this.ComandEndText.Click += new System.EventHandler(this.ComandEndText_Click);
            // 
            // DataSpeedName
            // 
            this.DataSpeedName.AutoSize = true;
            this.DataSpeedName.Depth = 0;
            this.DataSpeedName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataSpeedName.Location = new System.Drawing.Point(326, 77);
            this.DataSpeedName.MouseState = MaterialSkin.MouseState.HOVER;
            this.DataSpeedName.Name = "DataSpeedName";
            this.DataSpeedName.Size = new System.Drawing.Size(81, 19);
            this.DataSpeedName.TabIndex = 8;
            this.DataSpeedName.Text = "Data speed";
            this.DataSpeedName.Click += new System.EventHandler(this.DataSpeedName_Click);
            // 
            // ComPortName
            // 
            this.ComPortName.AutoSize = true;
            this.ComPortName.Depth = 0;
            this.ComPortName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ComPortName.Location = new System.Drawing.Point(326, 22);
            this.ComPortName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ComPortName.Name = "ComPortName";
            this.ComPortName.Size = new System.Drawing.Size(60, 19);
            this.ComPortName.TabIndex = 7;
            this.ComPortName.Text = "comport";
            this.ComPortName.Click += new System.EventHandler(this.ComPortName_Click);
            // 
            // ConectDisconect
            // 
            this.ConectDisconect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConectDisconect.Depth = 0;
            this.ConectDisconect.DrawShadows = true;
            this.ConectDisconect.HighEmphasis = true;
            this.ConectDisconect.Icon = null;
            this.ConectDisconect.Location = new System.Drawing.Point(167, 300);
            this.ConectDisconect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConectDisconect.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConectDisconect.Name = "ConectDisconect";
            this.ConectDisconect.Size = new System.Drawing.Size(79, 36);
            this.ConectDisconect.TabIndex = 6;
            this.ConectDisconect.Text = "Conect";
            this.ConectDisconect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConectDisconect.UseAccentColor = false;
            this.ConectDisconect.UseVisualStyleBackColor = true;
            this.ConectDisconect.Click += new System.EventHandler(this.ConectDisconect_Click);
            // 
            // WriteBuferSize
            // 
            this.WriteBuferSize.AutoResize = false;
            this.WriteBuferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WriteBuferSize.Depth = 0;
            this.WriteBuferSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WriteBuferSize.DropDownHeight = 174;
            this.WriteBuferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WriteBuferSize.DropDownWidth = 121;
            this.WriteBuferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WriteBuferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WriteBuferSize.FormattingEnabled = true;
            this.WriteBuferSize.IntegralHeight = false;
            this.WriteBuferSize.ItemHeight = 43;
            this.WriteBuferSize.Location = new System.Drawing.Point(198, 242);
            this.WriteBuferSize.MaxDropDownItems = 4;
            this.WriteBuferSize.MouseState = MaterialSkin.MouseState.OUT;
            this.WriteBuferSize.Name = "WriteBuferSize";
            this.WriteBuferSize.Size = new System.Drawing.Size(121, 49);
            this.WriteBuferSize.TabIndex = 4;
            this.WriteBuferSize.SelectedIndexChanged += new System.EventHandler(this.WriteBuferSize_SelectedIndexChanged);
            // 
            // ReadBuferSize
            // 
            this.ReadBuferSize.AutoResize = false;
            this.ReadBuferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReadBuferSize.Depth = 0;
            this.ReadBuferSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ReadBuferSize.DropDownHeight = 174;
            this.ReadBuferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReadBuferSize.DropDownWidth = 121;
            this.ReadBuferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ReadBuferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReadBuferSize.FormattingEnabled = true;
            this.ReadBuferSize.IntegralHeight = false;
            this.ReadBuferSize.ItemHeight = 43;
            this.ReadBuferSize.Location = new System.Drawing.Point(198, 187);
            this.ReadBuferSize.MaxDropDownItems = 4;
            this.ReadBuferSize.MouseState = MaterialSkin.MouseState.OUT;
            this.ReadBuferSize.Name = "ReadBuferSize";
            this.ReadBuferSize.Size = new System.Drawing.Size(121, 49);
            this.ReadBuferSize.TabIndex = 3;
            this.ReadBuferSize.SelectedIndexChanged += new System.EventHandler(this.ReadBuferSize_SelectedIndexChanged);
            // 
            // ComandEnd
            // 
            this.ComandEnd.AutoResize = false;
            this.ComandEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComandEnd.Depth = 0;
            this.ComandEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComandEnd.DropDownHeight = 174;
            this.ComandEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComandEnd.DropDownWidth = 121;
            this.ComandEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComandEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComandEnd.FormattingEnabled = true;
            this.ComandEnd.IntegralHeight = false;
            this.ComandEnd.ItemHeight = 43;
            this.ComandEnd.Location = new System.Drawing.Point(198, 132);
            this.ComandEnd.MaxDropDownItems = 4;
            this.ComandEnd.MouseState = MaterialSkin.MouseState.OUT;
            this.ComandEnd.Name = "ComandEnd";
            this.ComandEnd.Size = new System.Drawing.Size(121, 49);
            this.ComandEnd.TabIndex = 2;
            this.ComandEnd.SelectedIndexChanged += new System.EventHandler(this.ComandEnd_SelectedIndexChanged);
            // 
            // DataSpeed
            // 
            this.DataSpeed.AutoResize = false;
            this.DataSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataSpeed.Depth = 0;
            this.DataSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DataSpeed.DropDownHeight = 174;
            this.DataSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataSpeed.DropDownWidth = 121;
            this.DataSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DataSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataSpeed.FormattingEnabled = true;
            this.DataSpeed.IntegralHeight = false;
            this.DataSpeed.ItemHeight = 43;
            this.DataSpeed.Location = new System.Drawing.Point(198, 77);
            this.DataSpeed.MaxDropDownItems = 4;
            this.DataSpeed.MouseState = MaterialSkin.MouseState.OUT;
            this.DataSpeed.Name = "DataSpeed";
            this.DataSpeed.Size = new System.Drawing.Size(121, 49);
            this.DataSpeed.TabIndex = 1;
            this.DataSpeed.SelectedIndexChanged += new System.EventHandler(this.DataSpeed_SelectedIndexChanged);
            // 
            // ComPort
            // 
            this.ComPort.AutoResize = false;
            this.ComPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComPort.Depth = 0;
            this.ComPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComPort.DropDownHeight = 174;
            this.ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort.DropDownWidth = 121;
            this.ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComPort.FormattingEnabled = true;
            this.ComPort.IntegralHeight = false;
            this.ComPort.ItemHeight = 43;
            this.ComPort.Location = new System.Drawing.Point(198, 22);
            this.ComPort.MaxDropDownItems = 4;
            this.ComPort.MouseState = MaterialSkin.MouseState.OUT;
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 49);
            this.ComPort.TabIndex = 0;
            this.ComPort.SelectedIndexChanged += new System.EventHandler(this.ComPort_SelectedIndexChanged);
            // 
            // ComName
            // 
            this.ComName.Controls.Add(this.PlayButton);
            this.ComName.Controls.Add(this.PauseButton);
            this.ComName.Controls.Add(this.LineNumberCheckbox);
            this.ComName.Controls.Add(this.TimeStampCexBox);
            this.ComName.Controls.Add(this.ModeListTekst);
            this.ComName.Controls.Add(this.ModeList);
            this.ComName.Controls.Add(this.restartButon);
            this.ComName.Controls.Add(this.TextTimeName);
            this.ComName.Controls.Add(this.TextReadName);
            this.ComName.Controls.Add(this.TextWriteName);
            this.ComName.Controls.Add(textBox3);
            this.ComName.Controls.Add(textBox2);
            this.ComName.Controls.Add(textBox1);
            this.ComName.Controls.Add(this.AddToListButon);
            this.ComName.Controls.Add(this.SendButon);
            this.ComName.Controls.Add(this.WriteComand);
            this.ComName.ImageKey = "icons8-search-48.png";
            this.ComName.Location = new System.Drawing.Point(4, 55);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(1242, 641);
            this.ComName.TabIndex = 2;
            this.ComName.Text = "Com port";
            this.ComName.UseVisualStyleBackColor = true;
            // 
            // ModeList
            // 
            this.ModeList.AutoResize = false;
            this.ModeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModeList.Depth = 0;
            this.ModeList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ModeList.DropDownHeight = 174;
            this.ModeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeList.DropDownWidth = 121;
            this.ModeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ModeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ModeList.FormattingEnabled = true;
            this.ModeList.IntegralHeight = false;
            this.ModeList.ItemHeight = 43;
            this.ModeList.Location = new System.Drawing.Point(995, 121);
            this.ModeList.MaxDropDownItems = 4;
            this.ModeList.MouseState = MaterialSkin.MouseState.OUT;
            this.ModeList.Name = "ModeList";
            this.ModeList.Size = new System.Drawing.Size(121, 49);
            this.ModeList.TabIndex = 10;
            // 
            // restartButon
            // 
            this.restartButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restartButon.Depth = 0;
            this.restartButon.DrawShadows = true;
            this.restartButon.HighEmphasis = true;
            this.restartButon.Icon = null;
            this.restartButon.Location = new System.Drawing.Point(1032, 35);
            this.restartButon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.restartButon.MaximumSize = new System.Drawing.Size(125, 36);
            this.restartButon.MinimumSize = new System.Drawing.Size(125, 36);
            this.restartButon.MouseState = MaterialSkin.MouseState.HOVER;
            this.restartButon.Name = "restartButon";
            this.restartButon.Size = new System.Drawing.Size(125, 36);
            this.restartButon.TabIndex = 9;
            this.restartButon.Text = "Restart";
            this.restartButon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.restartButon.UseAccentColor = false;
            this.restartButon.UseVisualStyleBackColor = true;
            // 
            // TextTimeName
            // 
            this.TextTimeName.AutoSize = true;
            this.TextTimeName.Depth = 0;
            this.TextTimeName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTimeName.Location = new System.Drawing.Point(899, 92);
            this.TextTimeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextTimeName.Name = "TextTimeName";
            this.TextTimeName.Size = new System.Drawing.Size(37, 19);
            this.TextTimeName.TabIndex = 8;
            this.TextTimeName.Text = "Time";
            // 
            // TextReadName
            // 
            this.TextReadName.AutoSize = true;
            this.TextReadName.Depth = 0;
            this.TextReadName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextReadName.Location = new System.Drawing.Point(596, 92);
            this.TextReadName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextReadName.Name = "TextReadName";
            this.TextReadName.Size = new System.Drawing.Size(99, 19);
            this.TextReadName.TabIndex = 7;
            this.TextReadName.Text = "Read comand";
            // 
            // TextWriteName
            // 
            this.TextWriteName.AutoSize = true;
            this.TextWriteName.Depth = 0;
            this.TextWriteName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextWriteName.Location = new System.Drawing.Point(186, 92);
            this.TextWriteName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextWriteName.Name = "TextWriteName";
            this.TextWriteName.Size = new System.Drawing.Size(99, 19);
            this.TextWriteName.TabIndex = 6;
            this.TextWriteName.Text = "Write comand";
            // 
            // AddToListButon
            // 
            this.AddToListButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddToListButon.Depth = 0;
            this.AddToListButon.DrawShadows = true;
            this.AddToListButon.HighEmphasis = true;
            this.AddToListButon.Icon = null;
            this.AddToListButon.Location = new System.Drawing.Point(730, 35);
            this.AddToListButon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddToListButon.MaximumSize = new System.Drawing.Size(125, 36);
            this.AddToListButon.MinimumSize = new System.Drawing.Size(125, 36);
            this.AddToListButon.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddToListButon.Name = "AddToListButon";
            this.AddToListButon.Size = new System.Drawing.Size(125, 36);
            this.AddToListButon.TabIndex = 2;
            this.AddToListButon.Text = "Add to list";
            this.AddToListButon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddToListButon.UseAccentColor = false;
            this.AddToListButon.UseVisualStyleBackColor = true;
            // 
            // SendButon
            // 
            this.SendButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendButon.Depth = 0;
            this.SendButon.DrawShadows = true;
            this.SendButon.HighEmphasis = true;
            this.SendButon.Icon = null;
            this.SendButon.Location = new System.Drawing.Point(570, 35);
            this.SendButon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SendButon.MaximumSize = new System.Drawing.Size(125, 36);
            this.SendButon.MinimumSize = new System.Drawing.Size(125, 36);
            this.SendButon.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendButon.Name = "SendButon";
            this.SendButon.Size = new System.Drawing.Size(125, 36);
            this.SendButon.TabIndex = 1;
            this.SendButon.Text = "Send comand";
            this.SendButon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SendButon.UseAccentColor = false;
            this.SendButon.UseVisualStyleBackColor = true;
            // 
            // WriteComand
            // 
            this.WriteComand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriteComand.Depth = 0;
            this.WriteComand.Font = new System.Drawing.Font("Roboto", 12F);
            this.WriteComand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WriteComand.Location = new System.Drawing.Point(50, 35);
            this.WriteComand.MaxLength = 40;
            this.WriteComand.MinimumSize = new System.Drawing.Size(500, 50);
            this.WriteComand.MouseState = MaterialSkin.MouseState.OUT;
            this.WriteComand.Multiline = false;
            this.WriteComand.Name = "WriteComand";
            this.WriteComand.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.WriteComand.ShortcutsEnabled = false;
            this.WriteComand.Size = new System.Drawing.Size(500, 50);
            this.WriteComand.TabIndex = 0;
            this.WriteComand.Text = "";
            this.WriteComand.UseTallSize = false;
            // 
            // OpenName
            // 
            this.OpenName.ImageKey = "icons8-open-file-under-cursor-50.png";
            this.OpenName.Location = new System.Drawing.Point(4, 55);
            this.OpenName.Name = "OpenName";
            this.OpenName.Size = new System.Drawing.Size(1242, 641);
            this.OpenName.TabIndex = 3;
            this.OpenName.Text = "Open";
            this.OpenName.UseVisualStyleBackColor = true;
            // 
            // D3Name
            // 
            this.D3Name.ImageKey = "icons8-3d-48.png";
            this.D3Name.Location = new System.Drawing.Point(4, 55);
            this.D3Name.Name = "D3Name";
            this.D3Name.Size = new System.Drawing.Size(1242, 641);
            this.D3Name.TabIndex = 4;
            this.D3Name.Text = "3D";
            this.D3Name.UseVisualStyleBackColor = true;
            // 
            // ExsportName
            // 
            this.ExsportName.ImageKey = "icons8-separate-using-a-bar-code-50.png";
            this.ExsportName.Location = new System.Drawing.Point(4, 55);
            this.ExsportName.Name = "ExsportName";
            this.ExsportName.Size = new System.Drawing.Size(1242, 641);
            this.ExsportName.TabIndex = 5;
            this.ExsportName.Text = "  Exsport";
            this.ExsportName.UseVisualStyleBackColor = true;
            // 
            // SetingName
            // 
            this.SetingName.ImageKey = "icons8-settings-48.png";
            this.SetingName.Location = new System.Drawing.Point(4, 55);
            this.SetingName.Name = "SetingName";
            this.SetingName.Size = new System.Drawing.Size(1242, 641);
            this.SetingName.TabIndex = 6;
            this.SetingName.Text = "  Seting";
            this.SetingName.UseVisualStyleBackColor = true;
            // 
            // ModeListTekst
            // 
            this.ModeListTekst.AutoSize = true;
            this.ModeListTekst.Depth = 0;
            this.ModeListTekst.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ModeListTekst.Location = new System.Drawing.Point(1038, 92);
            this.ModeListTekst.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModeListTekst.Name = "ModeListTekst";
            this.ModeListTekst.Size = new System.Drawing.Size(41, 19);
            this.ModeListTekst.TabIndex = 11;
            this.ModeListTekst.Text = "Mode";
            // 
            // TimeStampCexBox
            // 
            this.TimeStampCexBox.AutoSize = true;
            this.TimeStampCexBox.Depth = 0;
            this.TimeStampCexBox.Location = new System.Drawing.Point(995, 194);
            this.TimeStampCexBox.Margin = new System.Windows.Forms.Padding(0);
            this.TimeStampCexBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TimeStampCexBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimeStampCexBox.Name = "TimeStampCexBox";
            this.TimeStampCexBox.Ripple = true;
            this.TimeStampCexBox.Size = new System.Drawing.Size(120, 37);
            this.TimeStampCexBox.TabIndex = 12;
            this.TimeStampCexBox.Text = "Time stamp";
            this.TimeStampCexBox.UseVisualStyleBackColor = true;
            // 
            // LineNumberCheckbox
            // 
            this.LineNumberCheckbox.AutoSize = true;
            this.LineNumberCheckbox.Depth = 0;
            this.LineNumberCheckbox.Location = new System.Drawing.Point(996, 246);
            this.LineNumberCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.LineNumberCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LineNumberCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LineNumberCheckbox.Name = "LineNumberCheckbox";
            this.LineNumberCheckbox.Ripple = true;
            this.LineNumberCheckbox.Size = new System.Drawing.Size(140, 37);
            this.LineNumberCheckbox.TabIndex = 13;
            this.LineNumberCheckbox.Text = "line numbering";
            this.LineNumberCheckbox.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PauseButton.Depth = 0;
            this.PauseButton.DrawShadows = true;
            this.PauseButton.HighEmphasis = true;
            this.PauseButton.Icon = null;
            this.PauseButton.Location = new System.Drawing.Point(995, 585);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PauseButton.MaximumSize = new System.Drawing.Size(125, 36);
            this.PauseButton.MinimumSize = new System.Drawing.Size(125, 36);
            this.PauseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(125, 36);
            this.PauseButton.TabIndex = 14;
            this.PauseButton.Text = "Pause";
            this.PauseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PauseButton.UseAccentColor = false;
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.Depth = 0;
            this.PlayButton.DrawShadows = true;
            this.PlayButton.HighEmphasis = true;
            this.PlayButton.Icon = null;
            this.PlayButton.Location = new System.Drawing.Point(996, 537);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PlayButton.MaximumSize = new System.Drawing.Size(125, 36);
            this.PlayButton.MinimumSize = new System.Drawing.Size(125, 36);
            this.PlayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(125, 36);
            this.PlayButton.TabIndex = 15;
            this.PlayButton.Text = "Play";
            this.PlayButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PlayButton.UseAccentColor = false;
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.HomeName);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.HomeName;
            this.Name = "Form1";
            this.Text = "USB Comand";
            this.HomeName.ResumeLayout(false);
            this.UsbName.ResumeLayout(false);
            this.UsbName.PerformLayout();
            this.ComName.ResumeLayout(false);
            this.ComName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl HomeName;
        private System.Windows.Forms.TabPage NameHome;
        private System.Windows.Forms.TabPage UsbName;
        private System.Windows.Forms.TabPage ComName;
        private System.Windows.Forms.TabPage OpenName;
        private System.Windows.Forms.TabPage D3Name;
        private System.Windows.Forms.TabPage ExsportName;
        private System.Windows.Forms.TabPage SetingName;
        private MaterialSkin.Controls.MaterialLabel WriteBuferSizeText;
        private MaterialSkin.Controls.MaterialLabel ReadBuferSizeText;
        private MaterialSkin.Controls.MaterialLabel ComandEndText;
        private MaterialSkin.Controls.MaterialLabel DataSpeedName;
        private MaterialSkin.Controls.MaterialLabel ComPortName;
        private MaterialSkin.Controls.MaterialButton ConectDisconect;
        private MaterialSkin.Controls.MaterialComboBox WriteBuferSize;
        private MaterialSkin.Controls.MaterialComboBox ReadBuferSize;
        private MaterialSkin.Controls.MaterialComboBox ComandEnd;
        private MaterialSkin.Controls.MaterialComboBox DataSpeed;
        private MaterialSkin.Controls.MaterialComboBox ComPort;
        private MaterialSkin.Controls.MaterialButton RefreshName;
        private MaterialSkin.Controls.MaterialTextBox WriteComand;
        private MaterialSkin.Controls.MaterialButton AddToListButon;
        private MaterialSkin.Controls.MaterialButton SendButon;
        private MaterialSkin.Controls.MaterialLabel TextTimeName;
        private MaterialSkin.Controls.MaterialLabel TextReadName;
        private MaterialSkin.Controls.MaterialLabel TextWriteName;
        private MaterialSkin.Controls.MaterialComboBox ModeList;
        private MaterialSkin.Controls.MaterialButton restartButon;
        private MaterialSkin.Controls.MaterialLabel ModeListTekst;
        private MaterialSkin.Controls.MaterialCheckbox TimeStampCexBox;
        private MaterialSkin.Controls.MaterialCheckbox LineNumberCheckbox;
        private MaterialSkin.Controls.MaterialButton PlayButton;
        private MaterialSkin.Controls.MaterialButton PauseButton;
    }
}

