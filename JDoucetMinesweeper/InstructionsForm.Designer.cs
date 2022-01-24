namespace JDoucetMinesweeper
{
   partial class InstructionsForm
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
         this.instructionsTextBox = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // instructionsTextBox
         // 
         this.instructionsTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.instructionsTextBox.Location = new System.Drawing.Point(13, 13);
         this.instructionsTextBox.Name = "instructionsTextBox";
         this.instructionsTextBox.ReadOnly = true;
         this.instructionsTextBox.Size = new System.Drawing.Size(899, 545);
         this.instructionsTextBox.TabIndex = 0;
         this.instructionsTextBox.Text = "";
         // 
         // InstructionsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(924, 570);
         this.Controls.Add(this.instructionsTextBox);
         this.Name = "InstructionsForm";
         this.Text = "Instructions: How to Play Minesweeper";
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.RichTextBox instructionsTextBox;
    }
}