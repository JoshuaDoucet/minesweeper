namespace JDoucetMinesweeper
{
   partial class MinesweeperForm
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
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.showLifetimeStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.showLifetimeStatsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.resetStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.instructionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 493);
         this.statusStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(582, 26);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 20);
         this.toolStripStatusLabel1.Text = "Current game time: 0";
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(582, 28);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // restartToolStripMenuItem
         // 
         this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLifetimeStatsToolStripMenuItem,
            this.restartGameToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.helpToolStripMenuItem1});
         this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
         this.restartToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
         this.restartToolStripMenuItem.Text = "Game";
         // 
         // showLifetimeStatsToolStripMenuItem
         // 
         this.showLifetimeStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLifetimeStatsToolStripMenuItem1,
            this.resetStatsToolStripMenuItem});
         this.showLifetimeStatsToolStripMenuItem.Name = "showLifetimeStatsToolStripMenuItem";
         this.showLifetimeStatsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         this.showLifetimeStatsToolStripMenuItem.Text = "Game Stats";
         // 
         // showLifetimeStatsToolStripMenuItem1
         // 
         this.showLifetimeStatsToolStripMenuItem1.Name = "showLifetimeStatsToolStripMenuItem1";
         this.showLifetimeStatsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
         this.showLifetimeStatsToolStripMenuItem1.Text = "Show Lifetime Stats";
         this.showLifetimeStatsToolStripMenuItem1.Click += new System.EventHandler(this.showLifetimeStatsToolStripMenuItem1_Click);
         // 
         // resetStatsToolStripMenuItem
         // 
         this.resetStatsToolStripMenuItem.Name = "resetStatsToolStripMenuItem";
         this.resetStatsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         this.resetStatsToolStripMenuItem.Text = "Reset Stats";
         this.resetStatsToolStripMenuItem.Click += new System.EventHandler(this.resetStatsToolStripMenuItem_Click);
         // 
         // restartGameToolStripMenuItem
         // 
         this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
         this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         this.restartGameToolStripMenuItem.Text = "Restart Game";
         this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem1
         // 
         this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
         this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
         this.exitToolStripMenuItem1.Text = "Exit";
         this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
         // 
         // helpToolStripMenuItem1
         // 
         this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
         this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
         this.helpToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
         this.helpToolStripMenuItem1.Text = "Help";
         // 
         // instructionsToolStripMenuItem1
         // 
         this.instructionsToolStripMenuItem1.Name = "instructionsToolStripMenuItem1";
         this.instructionsToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
         this.instructionsToolStripMenuItem1.Text = "Instructions";
         this.instructionsToolStripMenuItem1.Click += new System.EventHandler(this.instructionsToolStripMenuItem1_Click);
         // 
         // aboutToolStripMenuItem1
         // 
         this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
         this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
         this.aboutToolStripMenuItem1.Text = "About";
         this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
         // 
         // MinesweeperForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.ClientSize = new System.Drawing.Size(582, 519);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MinesweeperForm";
         this.ShowIcon = false;
         this.Text = "Minesweeper";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ToolStripMenuItem showLifetimeStatsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripMenuItem showLifetimeStatsToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem resetStatsToolStripMenuItem;
   }
}

