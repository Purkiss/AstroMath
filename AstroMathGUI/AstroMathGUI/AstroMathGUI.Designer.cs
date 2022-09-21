namespace AstroMathGUI
{
    partial class AstroMathGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroMathGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StarVelocityButton = new System.Windows.Forms.Button();
            this.restBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.observedBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StarDistanceButton = new System.Windows.Forms.Button();
            this.parallaxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TempButton = new System.Windows.Forms.Button();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.massExponent = new System.Windows.Forms.NumericUpDown();
            this.EventHorizonButton = new System.Windows.Forms.Button();
            this.massBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView = new System.Windows.Forms.ListView();
            this.starVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massExponent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.StarVelocityButton);
            this.groupBox1.Controls.Add(this.restBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.observedBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // StarVelocityButton
            // 
            resources.ApplyResources(this.StarVelocityButton, "StarVelocityButton");
            this.StarVelocityButton.Name = "StarVelocityButton";
            this.StarVelocityButton.UseVisualStyleBackColor = true;
            this.StarVelocityButton.Click += new System.EventHandler(this.StarVelocityButton_Click);
            // 
            // restBox
            // 
            resources.ApplyResources(this.restBox, "restBox");
            this.restBox.Name = "restBox";
            this.restBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestBox_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // observedBox
            // 
            resources.ApplyResources(this.observedBox, "observedBox");
            this.observedBox.Name = "observedBox";
            this.observedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObservedBox_KeyPress);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.StarDistanceButton);
            this.groupBox2.Controls.Add(this.parallaxBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // StarDistanceButton
            // 
            resources.ApplyResources(this.StarDistanceButton, "StarDistanceButton");
            this.StarDistanceButton.Name = "StarDistanceButton";
            this.StarDistanceButton.UseVisualStyleBackColor = true;
            this.StarDistanceButton.Click += new System.EventHandler(this.StarDistanceButton_Click);
            // 
            // parallaxBox
            // 
            resources.ApplyResources(this.parallaxBox, "parallaxBox");
            this.parallaxBox.Name = "parallaxBox";
            this.parallaxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParallaxBox_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.TempButton);
            this.groupBox3.Controls.Add(this.tempBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // TempButton
            // 
            resources.ApplyResources(this.TempButton, "TempButton");
            this.TempButton.Name = "TempButton";
            this.TempButton.UseVisualStyleBackColor = true;
            this.TempButton.Click += new System.EventHandler(this.TempButton_Click);
            // 
            // tempBox
            // 
            resources.ApplyResources(this.tempBox, "tempBox");
            this.tempBox.Name = "tempBox";
            this.tempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TempBox_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.massExponent);
            this.groupBox4.Controls.Add(this.EventHorizonButton);
            this.groupBox4.Controls.Add(this.massBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // massExponent
            // 
            resources.ApplyResources(this.massExponent, "massExponent");
            this.massExponent.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.massExponent.Name = "massExponent";
            this.massExponent.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // EventHorizonButton
            // 
            resources.ApplyResources(this.EventHorizonButton, "EventHorizonButton");
            this.EventHorizonButton.Name = "EventHorizonButton";
            this.EventHorizonButton.UseVisualStyleBackColor = true;
            this.EventHorizonButton.Click += new System.EventHandler(this.EventHorizonButton_Click);
            // 
            // massBox
            // 
            resources.ApplyResources(this.massBox, "massBox");
            this.massBox.Name = "massBox";
            this.massBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MassBox_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.textColourToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishUKToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishUKToolStripMenuItem
            // 
            resources.ApplyResources(this.englishUKToolStripMenuItem, "englishUKToolStripMenuItem");
            this.englishUKToolStripMenuItem.Name = "englishUKToolStripMenuItem";
            this.englishUKToolStripMenuItem.Click += new System.EventHandler(this.EnglishUKToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.GermanToolStripMenuItem_Click);
            // 
            // textColourToolStripMenuItem
            // 
            resources.ApplyResources(this.textColourToolStripMenuItem, "textColourToolStripMenuItem");
            this.textColourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.redToolStripMenuItem});
            this.textColourToolStripMenuItem.Name = "textColourToolStripMenuItem";
            // 
            // blackToolStripMenuItem
            // 
            resources.ApplyResources(this.blackToolStripMenuItem, "blackToolStripMenuItem");
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.BlackToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            resources.ApplyResources(this.whiteToolStripMenuItem, "whiteToolStripMenuItem");
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.WhiteToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            resources.ApplyResources(this.redToolStripMenuItem, "redToolStripMenuItem");
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            resources.ApplyResources(this.backgroundColorToolStripMenuItem, "backgroundColorToolStripMenuItem");
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            // 
            // chooseToolStripMenuItem
            // 
            resources.ApplyResources(this.chooseToolStripMenuItem, "chooseToolStripMenuItem");
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.ChooseToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            resources.ApplyResources(this.styleToolStripMenuItem, "styleToolStripMenuItem");
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightDarkToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            // 
            // lightDarkToolStripMenuItem
            // 
            resources.ApplyResources(this.lightDarkToolStripMenuItem, "lightDarkToolStripMenuItem");
            this.lightDarkToolStripMenuItem.Name = "lightDarkToolStripMenuItem";
            this.lightDarkToolStripMenuItem.Click += new System.EventHandler(this.DarkLightModeToolStripMenuItem_Click);
            // 
            // dataView
            // 
            resources.ApplyResources(this.dataView, "dataView");
            this.dataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.starVelocity,
            this.starDistance,
            this.tempKelvin,
            this.eventHorizon});
            this.dataView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataView.HideSelection = false;
            this.dataView.Name = "dataView";
            this.dataView.UseCompatibleStateImageBehavior = false;
            this.dataView.View = System.Windows.Forms.View.Details;
            // 
            // starVelocity
            // 
            resources.ApplyResources(this.starVelocity, "starVelocity");
            // 
            // starDistance
            // 
            resources.ApplyResources(this.starDistance, "starDistance");
            // 
            // tempKelvin
            // 
            resources.ApplyResources(this.tempKelvin, "tempKelvin");
            // 
            // eventHorizon
            // 
            resources.ApplyResources(this.eventHorizon, "eventHorizon");
            // 
            // AstroMathGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AstroMathGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massExponent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.Button StarVelocityButton;
        private System.Windows.Forms.TextBox restBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox observedBox;
        private System.Windows.Forms.Button StarDistanceButton;
        private System.Windows.Forms.TextBox parallaxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TempButton;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown massExponent;
        private System.Windows.Forms.Button EventHorizonButton;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightDarkToolStripMenuItem;
        private System.Windows.Forms.ListView dataView;
        private System.Windows.Forms.ColumnHeader starVelocity;
        private System.Windows.Forms.ColumnHeader tempKelvin;
        private System.Windows.Forms.ColumnHeader starDistance;
        private System.Windows.Forms.ColumnHeader eventHorizon;
        private System.Windows.Forms.Label label6;
    }
}

