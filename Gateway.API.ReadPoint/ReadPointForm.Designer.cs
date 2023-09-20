using System.Windows.Forms;

namespace Gateway.Api
{
    partial class ReadPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.buttonGetPoint = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelIPAddressMQTT = new System.Windows.Forms.Label();
            this.textBoxIPAddressMQTT = new System.Windows.Forms.TextBox();
            this.labelPortMQTT = new System.Windows.Forms.Label();
            this.labelIdMQTT = new System.Windows.Forms.Label();
            this.labelStingMQTT = new System.Windows.Forms.Label();
            this.textBoxPortMQTT = new System.Windows.Forms.TextBox();
            this.textBoxIdMQTT = new System.Windows.Forms.TextBox();
            this.textBoxStingMQTT = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBoxCheckPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Contraseña :";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 43);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(49, 13);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "Usuario :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(83, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(242, 20);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "aasa1234";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(83, 40);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(242, 20);
            this.textBoxUsername.TabIndex = 10;
            this.textBoxUsername.Text = "Administrator";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(83, 13);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(242, 20);
            this.textBoxIPAddress.TabIndex = 9;
            this.textBoxIPAddress.Text = "192.168.7.70";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(12, 16);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(71, 13);
            this.labelIPAddress.TabIndex = 8;
            this.labelIPAddress.Text = "Dirección IP :";
            // 
            // buttonGetPoint
            // 
            this.buttonGetPoint.Location = new System.Drawing.Point(20, 106);
            this.buttonGetPoint.Name = "buttonGetPoint";
            this.buttonGetPoint.Size = new System.Drawing.Size(310, 23);
            this.buttonGetPoint.TabIndex = 14;
            this.buttonGetPoint.Text = "Obtener";
            this.buttonGetPoint.UseVisualStyleBackColor = true;
            this.buttonGetPoint.Click += new System.EventHandler(this.buttonGetPoint_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // labelIPAddressMQTT
            // 
            this.labelIPAddressMQTT.AutoSize = true;
            this.labelIPAddressMQTT.Location = new System.Drawing.Point(350, 16);
            this.labelIPAddressMQTT.Name = "labelIPAddressMQTT";
            this.labelIPAddressMQTT.Size = new System.Drawing.Size(92, 13);
            this.labelIPAddressMQTT.TabIndex = 20;
            this.labelIPAddressMQTT.Text = "Dirección MQTT :";
            this.labelIPAddressMQTT.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIPAddressMQTT
            // 
            this.textBoxIPAddressMQTT.Location = new System.Drawing.Point(442, 13);
            this.textBoxIPAddressMQTT.Name = "textBoxIPAddressMQTT";
            this.textBoxIPAddressMQTT.Size = new System.Drawing.Size(262, 20);
            this.textBoxIPAddressMQTT.TabIndex = 21;
            this.textBoxIPAddressMQTT.Text = "192.168.43.253";
            this.textBoxIPAddressMQTT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelPortMQTT
            // 
            this.labelPortMQTT.AutoSize = true;
            this.labelPortMQTT.Location = new System.Drawing.Point(350, 43);
            this.labelPortMQTT.Name = "labelPortMQTT";
            this.labelPortMQTT.Size = new System.Drawing.Size(78, 13);
            this.labelPortMQTT.TabIndex = 22;
            this.labelPortMQTT.Text = "Puerto MQTT :";
            // 
            // labelIdMQTT
            // 
            this.labelIdMQTT.AutoSize = true;
            this.labelIdMQTT.Location = new System.Drawing.Point(350, 70);
            this.labelIdMQTT.Name = "labelIdMQTT";
            this.labelIdMQTT.Size = new System.Drawing.Size(58, 13);
            this.labelIdMQTT.TabIndex = 23;
            this.labelIdMQTT.Text = "ID MQTT :";
            // 
            // labelStingMQTT
            // 
            this.labelStingMQTT.AutoSize = true;
            this.labelStingMQTT.Location = new System.Drawing.Point(350, 97);
            this.labelStingMQTT.Name = "labelStingMQTT";
            this.labelStingMQTT.Size = new System.Drawing.Size(74, 13);
            this.labelStingMQTT.TabIndex = 24;
            this.labelStingMQTT.Text = "String MQTT :";
            // 
            // textBoxPortMQTT
            // 
            this.textBoxPortMQTT.Location = new System.Drawing.Point(442, 40);
            this.textBoxPortMQTT.Name = "textBoxPortMQTT";
            this.textBoxPortMQTT.Size = new System.Drawing.Size(262, 20);
            this.textBoxPortMQTT.TabIndex = 25;
            this.textBoxPortMQTT.Text = "1883";
            // 
            // textBoxIdMQTT
            // 
            this.textBoxIdMQTT.Location = new System.Drawing.Point(442, 67);
            this.textBoxIdMQTT.Name = "textBoxIdMQTT";
            this.textBoxIdMQTT.Size = new System.Drawing.Size(262, 20);
            this.textBoxIdMQTT.TabIndex = 26;
            this.textBoxIdMQTT.Text = "BrokerPaula";
            // 
            // textBoxStingMQTT
            // 
            this.textBoxStingMQTT.Location = new System.Drawing.Point(442, 94);
            this.textBoxStingMQTT.Name = "textBoxStingMQTT";
            this.textBoxStingMQTT.Size = new System.Drawing.Size(262, 20);
            this.textBoxStingMQTT.TabIndex = 27;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(442, 140);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(262, 23);
            this.buttonConnect.TabIndex = 28;
            this.buttonConnect.Text = "Conectar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 169);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(307, 20);
            this.textBoxSearch.TabIndex = 33;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 211);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(315, 379);
            this.checkedListBox1.TabIndex = 35;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // textBoxCheckPoints
            // 
            this.textBoxCheckPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCheckPoints.Location = new System.Drawing.Point(389, 211);
            this.textBoxCheckPoints.Multiline = true;
            this.textBoxCheckPoints.Name = "textBoxCheckPoints";
            this.textBoxCheckPoints.ReadOnly = true;
            this.textBoxCheckPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCheckPoints.Size = new System.Drawing.Size(315, 379);
            this.textBoxCheckPoints.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barra de busqueda";
            // 
            // ReadPoint
            // 
            this.AcceptButton = this.buttonGetPoint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCheckPoints);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxStingMQTT);
            this.Controls.Add(this.textBoxIdMQTT);
            this.Controls.Add(this.textBoxPortMQTT);
            this.Controls.Add(this.labelStingMQTT);
            this.Controls.Add(this.labelIdMQTT);
            this.Controls.Add(this.labelPortMQTT);
            this.Controls.Add(this.textBoxIPAddressMQTT);
            this.Controls.Add(this.labelIPAddressMQTT);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonGetPoint);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.labelIPAddress);
            this.Name = "ReadPoint";
            this.Text = "SMP Gateway API";
            this.Load += new System.EventHandler(this.ReadPoint_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //SMP
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Button buttonGetPoint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        //MQTT
        private Label labelIPAddressMQTT;
        private TextBox textBoxIPAddressMQTT;
        private Label labelPortMQTT;
        private Label labelIdMQTT;
        private Label labelStingMQTT;
        private TextBox textBoxPortMQTT;
        private TextBox textBoxIdMQTT;
        private TextBox textBoxStingMQTT;
        private Button buttonConnect;
        private TextBox textBoxSearch;
        private CheckedListBox checkedListBox1;
        private TextBox textBoxCheckPoints;
        private Label label1;
    }
}

