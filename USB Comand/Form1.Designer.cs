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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HomeName = new MaterialSkin.Controls.MaterialTabControl();
            this.NameHome = new System.Windows.Forms.TabPage();
            this.UsbName = new System.Windows.Forms.TabPage();
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
            this.OpenName = new System.Windows.Forms.TabPage();
            this.D3Name = new System.Windows.Forms.TabPage();
            this.ExsportName = new System.Windows.Forms.TabPage();
            this.SetingName = new System.Windows.Forms.TabPage();
            this.RefreshName = new MaterialSkin.Controls.MaterialButton();
            this.HomeName.SuspendLayout();
            this.UsbName.SuspendLayout();
            this.SuspendLayout();
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
            this.HomeName.Size = new System.Drawing.Size(1200, 700);
            this.HomeName.TabIndex = 0;
            // 
            // NameHome
            // 
            this.NameHome.ImageKey = "icons8-home-48.png";
            this.NameHome.Location = new System.Drawing.Point(4, 55);
            this.NameHome.Name = "NameHome";
            this.NameHome.Padding = new System.Windows.Forms.Padding(3);
            this.NameHome.Size = new System.Drawing.Size(1192, 641);
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
            this.UsbName.Size = new System.Drawing.Size(1192, 641);
            this.UsbName.TabIndex = 1;
            this.UsbName.Text = "USB";
            this.UsbName.UseVisualStyleBackColor = true;
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
            this.ComName.ImageKey = "icons8-search-48.png";
            this.ComName.Location = new System.Drawing.Point(4, 55);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(1192, 641);
            this.ComName.TabIndex = 2;
            this.ComName.Text = "Com port";
            this.ComName.UseVisualStyleBackColor = true;
            // 
            // OpenName
            // 
            this.OpenName.ImageKey = "icons8-open-file-under-cursor-50.png";
            this.OpenName.Location = new System.Drawing.Point(4, 55);
            this.OpenName.Name = "OpenName";
            this.OpenName.Size = new System.Drawing.Size(1192, 641);
            this.OpenName.TabIndex = 3;
            this.OpenName.Text = "Open";
            this.OpenName.UseVisualStyleBackColor = true;
            // 
            // D3Name
            // 
            this.D3Name.ImageKey = "icons8-3d-48.png";
            this.D3Name.Location = new System.Drawing.Point(4, 55);
            this.D3Name.Name = "D3Name";
            this.D3Name.Size = new System.Drawing.Size(1192, 641);
            this.D3Name.TabIndex = 4;
            this.D3Name.Text = "3D";
            this.D3Name.UseVisualStyleBackColor = true;
            // 
            // ExsportName
            // 
            this.ExsportName.ImageKey = "icons8-separate-using-a-bar-code-50.png";
            this.ExsportName.Location = new System.Drawing.Point(4, 55);
            this.ExsportName.Name = "ExsportName";
            this.ExsportName.Size = new System.Drawing.Size(1192, 641);
            this.ExsportName.TabIndex = 5;
            this.ExsportName.Text = "  Exsport";
            this.ExsportName.UseVisualStyleBackColor = true;
            // 
            // SetingName
            // 
            this.SetingName.ImageKey = "icons8-settings-48.png";
            this.SetingName.Location = new System.Drawing.Point(4, 55);
            this.SetingName.Name = "SetingName";
            this.SetingName.Size = new System.Drawing.Size(1192, 641);
            this.SetingName.TabIndex = 6;
            this.SetingName.Text = "  Seting";
            this.SetingName.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.HomeName);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.HomeName;
            this.Name = "Form1";
            this.Text = "USB Comand";
            this.HomeName.ResumeLayout(false);
            this.UsbName.ResumeLayout(false);
            this.UsbName.PerformLayout();
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
    }
}

