namespace Main_Menu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewButton = new System.Windows.Forms.Button();
            this.NewFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveMod = new System.Windows.Forms.Button();
            this.Rainbow = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.About = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.HexEdit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WepBarrel = new System.Windows.Forms.TabPage();
            this.Zoom = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Gestalt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExternalNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.External = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AttributeNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Attribute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FirinMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WepCard = new System.Windows.Forms.TabPage();
            this.Rarity = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.NewWepName = new System.Windows.Forms.TextBox();
            this.RedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrigWepName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.General = new System.Windows.Forms.TabPage();
            this.EridiumPickup = new System.Windows.Forms.CheckBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.About.SuspendLayout();
            this.Settings.SuspendLayout();
            this.WepBarrel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeNum)).BeginInit();
            this.WepCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rarity)).BeginInit();
            this.General.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewButton.Location = new System.Drawing.Point(1, 1);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "New Mod";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NewFile
            // 
            this.NewFile.RestoreDirectory = true;
            // 
            // SaveMod
            // 
            this.SaveMod.Location = new System.Drawing.Point(73, 1);
            this.SaveMod.Name = "SaveMod";
            this.SaveMod.Size = new System.Drawing.Size(75, 23);
            this.SaveMod.TabIndex = 3;
            this.SaveMod.Text = "Save Mod";
            this.SaveMod.UseVisualStyleBackColor = true;
            this.SaveMod.Click += new System.EventHandler(this.SaveMod_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fontDialog1.MaxSize = 8;
            this.fontDialog1.MinSize = 8;
            // 
            // About
            // 
            this.About.Controls.Add(this.label21);
            this.About.Controls.Add(this.linkLabel5);
            this.About.Controls.Add(this.label20);
            this.About.Controls.Add(this.linkLabel4);
            this.About.Controls.Add(this.label19);
            this.About.Controls.Add(this.linkLabel3);
            this.About.Controls.Add(this.label18);
            this.About.Controls.Add(this.linkLabel2);
            this.About.Controls.Add(this.label15);
            this.About.Controls.Add(this.linkLabel1);
            this.About.Controls.Add(this.label14);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(893, 429);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(213, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 20);
            this.label21.TabIndex = 10;
            this.label21.Text = "for helping debug";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.Location = new System.Drawing.Point(86, 78);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(121, 20);
            this.linkLabel5.TabIndex = 9;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "LightChaosman";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 8;
            this.label20.Text = "Credit to";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(299, 46);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(159, 20);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Borderlands2Patcher";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(214, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "for creating";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(83, 46);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(133, 20);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "AnotherBugworm";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Credit to";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(9, 399);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(140, 20);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Community Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(214, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "for use in Borderlands 2\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.Location = new System.Drawing.Point(109, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FromDarkHell";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Developed by ";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.HexEdit);
            this.Settings.Controls.Add(this.checkBox1);
            this.Settings.Controls.Add(this.button1);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(893, 429);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // HexEdit
            // 
            this.HexEdit.Location = new System.Drawing.Point(3, 43);
            this.HexEdit.Name = "HexEdit";
            this.HexEdit.Size = new System.Drawing.Size(141, 23);
            this.HexEdit.TabIndex = 2;
            this.HexEdit.Text = "Apply Hex Edits to BL2";
            this.HexEdit.UseVisualStyleBackColor = true;
            this.HexEdit.Click += new System.EventHandler(this.HexEdit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Dark Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Text Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WepBarrel
            // 
            this.WepBarrel.Controls.Add(this.Zoom);
            this.WepBarrel.Controls.Add(this.numericUpDown1);
            this.WepBarrel.Controls.Add(this.label17);
            this.WepBarrel.Controls.Add(this.label16);
            this.WepBarrel.Controls.Add(this.label1);
            this.WepBarrel.Controls.Add(this.checkBox2);
            this.WepBarrel.Controls.Add(this.Gestalt);
            this.WepBarrel.Controls.Add(this.label13);
            this.WepBarrel.Controls.Add(this.label11);
            this.WepBarrel.Controls.Add(this.label10);
            this.WepBarrel.Controls.Add(this.ExternalNum);
            this.WepBarrel.Controls.Add(this.label9);
            this.WepBarrel.Controls.Add(this.External);
            this.WepBarrel.Controls.Add(this.label8);
            this.WepBarrel.Controls.Add(this.AttributeNum);
            this.WepBarrel.Controls.Add(this.label7);
            this.WepBarrel.Controls.Add(this.Attribute);
            this.WepBarrel.Controls.Add(this.label6);
            this.WepBarrel.Controls.Add(this.FirinMode);
            this.WepBarrel.Controls.Add(this.label5);
            this.WepBarrel.Location = new System.Drawing.Point(4, 22);
            this.WepBarrel.Name = "WepBarrel";
            this.WepBarrel.Size = new System.Drawing.Size(893, 429);
            this.WepBarrel.TabIndex = 2;
            this.WepBarrel.Text = "Weapon Barrel";
            this.WepBarrel.UseVisualStyleBackColor = true;
            // 
            // Zoom
            // 
            this.Zoom.FormattingEnabled = true;
            this.Zoom.Items.AddRange(new object[] {
            "Projectiles Per Shot",
            "Projectile Speed",
            "Weapon Damage",
            "Mag Size",
            "Burst Count",
            "Fire Rate",
            "Recoil",
            "Shot Cost",
            "Extra Shot Chance",
            "Weapon Accuracy",
            "Reload Speed"});
            this.Zoom.Location = new System.Drawing.Point(198, 103);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(121, 21);
            this.Zoom.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(349, 104);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(325, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "by";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(123, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Increase the ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Zoom Attribute Effects:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 175);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(137, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Grenade Damage Type";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Gestalt
            // 
            this.Gestalt.FormattingEnabled = true;
            this.Gestalt.Items.AddRange(new object[] {
            "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Bandit",
            "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Dahl",
            "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Vladof",
            "GD_Weap_Launchers.Barrel.L_Barrel_Bandit",
            "GD_Weap_Launchers.Barrel.L_Barrel_Maliwan",
            "GD_Weap_Launchers.Barrel.L_Barrel_Tediore",
            "GD_Weap_Launchers.Barrel.L_Barrel_Torgue",
            "GD_Weap_Launchers.Barrel.L_Barrel_Vladof",
            "GD_Weap_Pistol.Barrel.Pistol_Barrel_Bandit",
            "GD_Weap_Pistol.Barrel.Pistol_Barrel_Dahl",
            "GD_Weap_Pistol.Barrel.Pistol_Barrel_Maliwan",
            "GD_Weap_Pistol.Barrel.Pistol_Barrel_Tediore",
            "GD_Weap_Pistol.Barrel.Pistol_Barrel_Torgue",
            "GD_Weap_Shotgun.Barrel.SG_Barrel_Hyperion",
            "GD_Weap_Shotgun.Barrel.SG_Barrel_Jakobs",
            "GD_Weap_Shotgun.Barrel.SG_Barrel_Tediore",
            "GD_Weap_SMG.Barrel.SMG_Barrel_Maliwan",
            "GD_Weap_SMG.Barrel.SMG_Barrel_Bandit",
            "GD_Weap_SMG.Barrel.SMG_Barrel_Tediore",
            "GD_Weap_SniperRifles.Barrel.SR_Barrel_Dahl",
            "GD_Weap_SniperRifles.Barrel.SR_Barrel_Hyperion",
            "GD_Weap_SniperRifles.Barrel.SR_Barrel_Jakobs",
            "GD_Weap_SniperRifles.Barrel.SR_Barrel_Maliwan",
            "GD_Weap_SniperRifles.Barrel.SR_Barrel_Vladof"});
            this.Gestalt.Location = new System.Drawing.Point(129, 136);
            this.Gestalt.Name = "Gestalt";
            this.Gestalt.Size = new System.Drawing.Size(747, 21);
            this.Gestalt.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Gestalt Skeletal Mesh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Weapon Attribute Effects:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "External Attribute Effects:";
            // 
            // ExternalNum
            // 
            this.ExternalNum.Location = new System.Drawing.Point(369, 72);
            this.ExternalNum.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.ExternalNum.Minimum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            -2147483648});
            this.ExternalNum.Name = "ExternalNum";
            this.ExternalNum.Size = new System.Drawing.Size(81, 20);
            this.ExternalNum.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "by";
            // 
            // External
            // 
            this.External.FormattingEnabled = true;
            this.External.Items.AddRange(new object[] {
            "Convert Damage to Healing Percent"});
            this.External.Location = new System.Drawing.Point(218, 69);
            this.External.Name = "External";
            this.External.Size = new System.Drawing.Size(121, 21);
            this.External.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Increase the ";
            // 
            // AttributeNum
            // 
            this.AttributeNum.Location = new System.Drawing.Point(369, 40);
            this.AttributeNum.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.AttributeNum.Minimum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            -2147483648});
            this.AttributeNum.Name = "AttributeNum";
            this.AttributeNum.Size = new System.Drawing.Size(81, 20);
            this.AttributeNum.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "by";
            // 
            // Attribute
            // 
            this.Attribute.FormattingEnabled = true;
            this.Attribute.Items.AddRange(new object[] {
            "Projectiles Per Shot",
            "Projectile Speed",
            "Weapon Damage",
            "Mag Size",
            "Burst Count",
            "Fire Rate",
            "Recoil",
            "Shot Cost",
            "Extra Shot Chance",
            "Weapon Accuracy",
            "Reload Speed"});
            this.Attribute.Location = new System.Drawing.Point(218, 37);
            this.Attribute.Name = "Attribute";
            this.Attribute.Size = new System.Drawing.Size(121, 21);
            this.Attribute.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Increase the ";
            // 
            // FirinMode
            // 
            this.FirinMode.FormattingEnabled = true;
            this.FirinMode.Items.AddRange(new object[] {
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Hammerbuster",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Hail",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Hail_Child",
            "GD_Weap_AssaultRifle.FiringModes.Bullets_Assault_Torgue_GyroJet",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Dahl_Hornet",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Dahl_Teapot",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Maliwan",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Maliwan_ThunderballFists",
            "GD_Weap_Pistol.FiringModes.Bullets_Pistol_Bandit_Tinderbox",
            "GD_Weap_Pistol.FiringModes.Bullets_Pistol_Torgue_Calla",
            "GD_Weap_Pistol.FiringModes.Bullets_Pistol_Torgue_CallaChild",
            "GD_Weap_Pistol.FiringModes.Bullets_Pistol_Torgue_GyroJet",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Blockhead",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Teeth",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_Flakker_Child",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_Flakker_Child_2",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_Flakker_Child_3",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_GyroJet",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_Landscaper",
            "GD_Weap_SMG.FiringModes.Bullet_Plasma_Default",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_Chulainn",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_HellFire",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Maliwan",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Volcano",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Default",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_ChereAmie",
            "GD_GrenadeMods.FiringModes.FiringModeDef_BouncingBettyBeam",
            "GD_GrenadeMods.FiringModes.FiringModeDef_TeslaGrenadeBeam",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Bandit_Madhouse",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Bandit_Madhouse_Child",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Dahl_Veruc",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Assault_Default",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Blaster_Dahl",
            "GD_Weap_AssaultRifle.FiringModes.Bullet_Blaster_Default",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_Bandit",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_Dahl_Grenade",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_Jakobs",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_KerBlaster",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_Torgue",
            "GD_Weap_AssaultRifle.FiringModes.FM_Rocket_Vladof",
            "GD_Weap_Launchers.FiringModes.FM_Alien",
            "GD_Weap_Launchers.FiringModes.FM_Alien_Bandit",
            "GD_Weap_Launchers.FiringModes.FM_Alien_Maliwan_Norfleet",
            "GD_Weap_Launchers.FiringModes.FM_Alien_Maliwan_PBFG",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Bandit",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Bandit_BadaBoom",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Maliwan",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Maliwan_Pyrophobia",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Maliwan_TheHive",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Mongol",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Torgue",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Tediore",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Torgue_Creamer",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Torgue_Nukem",
            "GD_Weap_Launchers.FiringModes.FM_Rocket_Vladof",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Default",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Hyperion_Fibber_1",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Hyperion_Fibber_2",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Hyperion_Fibber_3",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Infinity",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_LogansGun",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Spiker",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Spiker_Homing",
            "GD_Weap_Pistol.FiringModes.Bullet_Pistol_Spiker_Homing_Dahlminator",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_ConferenceCall",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_ConferenceCall_Child",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_HeartBreaker",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Hyperion",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_HyperionBarrel",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Octo",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_TidalWave",
            "GD_Weap_Shotgun.FiringModes.Bullet_Shotgun_Triquetra",
            "GD_Weap_Shotgun.FiringModes.Bullets_Shotgun_Torgue_Flakker",
            "GD_Weap_Shotgun.FiringModes.Bullets_Splatgun",
            "GD_Weap_Shotgun.FiringModes.Bullets_Splatgun_Hyperion",
            "GD_Weap_SMG.FiringModes.Bullet_Plasma_Bandit",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_Default",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_Commerce",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_Emperor",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_Lascaux",
            "GD_Weap_SMG.FiringModes.Bullet_SMG_TheBane",
            "GD_Weap_SniperRifles.FiringModes.Bullet_RailGun",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Default",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Longbow",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Lyudmila",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Pitchfork",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Pitchfork_Child_2",
            "GD_Weap_SniperRifles.FiringModes.Bullet_Sniper_Pitchfork_Child",
            "GD_Aster_RaidWeapons.Shotguns.Bullet_Shotgun_Omen",
            "GD_Aster_RaidWeapons.SMGs.Bullet_SMG_Plasma_Florentine",
            "GD_Aster_Weapons.FiringModes.Bullet_Assault_Ogre",
            "GD_Aster_Weapons.FiringModes.Bullet_Pistol_Maliwan_GrogNozzle",
            "GD_Aster_Weapons.FiringModes.Bullet_Shotgun_Swordsplosion",
            "GD_Aster_RaidWeapons.AssaultRifles.Bullet_Pistol_Seeker_Homing",
            "GD_Aster_Weapons.FiringModes.Bullet_SMG_Orc",
            "GD_Aster_Weapons.FiringModes.Bullet_SMG_Orc_Child",
            "GD_Gladiolus_Weapons.FiringModes.Bullet_Assault_Sawbar_Child",
            "GD_Gladiolus_Weapons.FiringModes.Bullet_Sniper_Maliwan_Storm",
            "GD_Gladiolus_Weapons.FiringModes.Bullet_Assault_Sawbar",
            "GD_Gladiolus_Weapons.FiringModes.Bullet_Pistol_Stalker",
            "GD_Gladiolus_Weapons.FiringModes.FM_Rocket_Dahl_Grenade_Bearcat",
            "GD_Gladiolus_Weapons.FiringModes.FM_Rocket_Torgue_Tunguska",
            "GD_Iris_Weapons.FiringModes.Bullet_Sniper_Cobra",
            "GD_Iris_Weapons.FiringModes.Bullet_Assault_Kitten",
            "GD_Iris_Weapons.FiringModes.Bullets_Pistol_Torgue_PocketRocket",
            "GD_Iris_Weapons.FiringModes.Bullets_Splatgun_SlowHand",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Assault_Bekah",
            "GD_Iris_Weapons.FiringModes.FM_Rocket_Grenade_BoomPuppy",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Assault_Bekah",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Assault_Bekah_Ch1",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Pistol_Homing_Wanderlust",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Sniper_Jakobs_Godfinger",
            "GD_Lobelia_Weapons.FiringModes.Bullet_Sniper_Jakobs_Godfinger_Ch1",
            "GD_Lobelia_Weapons.FiringModes.FM_Rocket_Torgue_Carnage",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Pistol_Maliwan_Evie",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Sniper_Maliwan_Pimpernel",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Sniper_Maliwan_Pimpernel_Child2",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Sniper_Maliwan_Pimpernel_Child",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Shotgun_OrphanMaker",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_Shotgun_JollyRoger",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_SMG_SandHawk",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_SMG_SandHawk_Child0",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_SMG_SandHawk_Child1",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_SMG_SandHawk_Child2",
            "GD_Orchid_BossWeapons.FiringModes.Bullet_SMG_SandHawk_Child3",
            "GD_Orchid_BossWeapons.FiringModes.FM_Rocket_12Pounder",
            "GD_Orchid_BossWeapons.RPG.Ahab.Orchid_Boss_Ahab_FireMode",
            "GD_Orchid_RaidWeapons.RPG.Ahab.Orchid_Seraph_Ahab_FireMode",
            "GD_Orchid_RaidWeapons.Shotgun.Spitter.Orchid_Seraph_Spitter_FireMode",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Pistol_Maliwan_Infection",
            "GD_Sage_Weapons.FiringModes.Bullet_Plasma_YellowJacket",
            "GD_Sage_Weapons.FiringModes.Bullet_Shotgun_Twister",
            "GD_Sage_HarpoonGun.Projectile.Sage_HarpoonGun_FireMode",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Assault_LeadStorm",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Assault_LeadStorm_Child",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Shotgun_Interfacer",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Shotgun_Interfacer_Child",
            "GD_Sage_RaidWeapons.FiringModes.Bullet_Shotgun_Interfacer_Child_Left",
            "GD_Sage_Weapons.FiringModes.Bullet_Shotgun_Hydra"});
            this.FirinMode.Location = new System.Drawing.Point(126, 10);
            this.FirinMode.Name = "FirinMode";
            this.FirinMode.Size = new System.Drawing.Size(750, 21);
            this.FirinMode.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weapon Firing Mode: ";
            // 
            // WepCard
            // 
            this.WepCard.Controls.Add(this.Rarity);
            this.WepCard.Controls.Add(this.label12);
            this.WepCard.Controls.Add(this.NewWepName);
            this.WepCard.Controls.Add(this.RedText);
            this.WepCard.Controls.Add(this.label4);
            this.WepCard.Controls.Add(this.OrigWepName);
            this.WepCard.Controls.Add(this.label3);
            this.WepCard.Controls.Add(this.label2);
            this.WepCard.Location = new System.Drawing.Point(4, 22);
            this.WepCard.Name = "WepCard";
            this.WepCard.Padding = new System.Windows.Forms.Padding(3);
            this.WepCard.Size = new System.Drawing.Size(893, 429);
            this.WepCard.TabIndex = 1;
            this.WepCard.Text = "Weapon Card";
            this.WepCard.UseVisualStyleBackColor = true;
            // 
            // Rarity
            // 
            this.Rarity.Location = new System.Drawing.Point(52, 77);
            this.Rarity.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.Rarity.Minimum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            -2147483648});
            this.Rarity.Name = "Rarity";
            this.Rarity.Size = new System.Drawing.Size(92, 20);
            this.Rarity.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Rarity:";
            // 
            // NewWepName
            // 
            this.NewWepName.Location = new System.Drawing.Point(279, 0);
            this.NewWepName.Name = "NewWepName";
            this.NewWepName.Size = new System.Drawing.Size(173, 20);
            this.NewWepName.TabIndex = 5;
            // 
            // RedText
            // 
            this.RedText.Location = new System.Drawing.Point(113, 43);
            this.RedText.Name = "RedText";
            this.RedText.Size = new System.Drawing.Size(173, 20);
            this.RedText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "is now";
            // 
            // OrigWepName
            // 
            this.OrigWepName.FormattingEnabled = true;
            this.OrigWepName.Items.AddRange(new object[] {
            "12 Pounder",
            "Bad Touch",
            "Bane",
            "Blockhead",
            "Bone Shredder",
            "Boom Puppy",
            "Buffalo",
            "CHOPPER",
            "Chulainn",
            "Chère-amie",
            "Cobra",
            "Commerce",
            "Creamer",
            "Crit",
            "Dahlminator",
            "Damned Cowboy",
            "Dog",
            "Elephant Gun",
            "Evil Smasher",
            "Fibber - Shotgun",
            "Fibber - Crit",
            "Fibber - Ricochet",
            "Tinderbox",
            "Fremington\'s Edge",
            "Good Touch",
            "Greed",
            "Grog Nozzle",
            "Gwen\'s Head",
            "Hail",
            "Heart Breaker",
            "Hive",
            "Hydra",
            "Jolly Roger",
            "Judge",
            "Kitten",
            "Lady Fist",
            "Landscaper",
            "Lascaux",
            "Law",
            "Little Evie",
            "Morning Star",
            "Octo",
            "Order",
            "Orphan Maker",
            "Pimpernel",
            "Pocket Rocket",
            "Pot O\' Gold",
            "Rapier",
            "Rex",
            "Roaster",
            "RokSalt",
            "Sandhawk",
            "Scorpio",
            "Shotgun 1340",
            "Sloth",
            "Slow Hand",
            "Stinkpot",
            "Stomper",
            "SWORDSPLOSION",
            "Teapot",
            "Teeth of Terramorphous",
            "Tidal Wave",
            "Trespasser",
            "Triquetra",
            "Twister",
            "Veritas",
            "Yellow Jacket",
            "Madhous!",
            "Gub",
            "Badaboom",
            "Slagga",
            "Sledge\'s Shotgun",
            "Veruc",
            "Hornet",
            "Pitchfork",
            "Emperor",
            "Logan\'s Gun",
            "Conference Call",
            "Invader",
            "Longbow",
            "Bitch",
            "Hammerbuster",
            "Maggie",
            "Striker",
            "Skullmasher",
            "Thunderball Fists",
            "Norfleet",
            "Pyrophobia",
            "Volcano",
            "HellFire",
            "Gunerang",
            "Bunny",
            "Deliverance",
            "Baby Maker",
            "KerBlaster",
            "Ogre",
            "Unkempt Harold",
            "Nukem",
            "Flakker",
            "Shredifier",
            "Infinity",
            "Mongol",
            "Lyuda"});
            this.OrigWepName.Location = new System.Drawing.Point(97, 0);
            this.OrigWepName.Name = "OrigWepName";
            this.OrigWepName.Size = new System.Drawing.Size(132, 21);
            this.OrigWepName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Weapon Red-Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Weapon Name:";
            // 
            // General
            // 
            this.General.Controls.Add(this.EridiumPickup);
            this.General.ImageIndex = 0;
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(893, 429);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // EridiumPickup
            // 
            this.EridiumPickup.AutoSize = true;
            this.EridiumPickup.Location = new System.Drawing.Point(3, 16);
            this.EridiumPickup.Name = "EridiumPickup";
            this.EridiumPickup.Size = new System.Drawing.Size(269, 17);
            this.EridiumPickup.TabIndex = 1;
            this.EridiumPickup.Text = "Auto Eridium, Torgue Token, Seraph Crystal Pickup";
            this.EridiumPickup.UseVisualStyleBackColor = true;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.General);
            this.Tabs.Controls.Add(this.WepCard);
            this.Tabs.Controls.Add(this.WepBarrel);
            this.Tabs.Controls.Add(this.Settings);
            this.Tabs.Controls.Add(this.About);
            this.Tabs.Location = new System.Drawing.Point(0, 30);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(901, 455);
            this.Tabs.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 476);
            this.Controls.Add(this.SaveMod);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.NewButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BL2CPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.WepBarrel.ResumeLayout(false);
            this.WepBarrel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeNum)).EndInit();
            this.WepCard.ResumeLayout(false);
            this.WepCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rarity)).EndInit();
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewButton;
        public System.Windows.Forms.SaveFileDialog NewFile;
        public System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button SaveMod;
        private System.Windows.Forms.Timer Rainbow;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage WepBarrel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox Gestalt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ExternalNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox External;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AttributeNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Attribute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FirinMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage WepCard;
        private System.Windows.Forms.NumericUpDown Rarity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NewWepName;
        private System.Windows.Forms.TextBox RedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OrigWepName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.CheckBox EridiumPickup;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.ComboBox Zoom;
        private System.Windows.Forms.Button HexEdit;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label20;
    }
}

