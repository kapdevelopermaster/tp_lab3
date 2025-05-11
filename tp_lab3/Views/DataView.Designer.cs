namespace tp_lab3.Views
{
    partial class DataView
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();

            this.btnLoadTrainingFile = new System.Windows.Forms.Button();
            this.dataTrainingGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingGridView)).BeginInit();

            this.btnLoadRateFile = new System.Windows.Forms.Button();
            this.dataRateGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRateGridView)).BeginInit();

            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(881, 686);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataTrainingGridView);
            this.tabPage1.Controls.Add(this.btnLoadTrainingFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные тренировок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataRateGridView);
            this.tabPage2.Controls.Add(this.btnLoadRateFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные курса валют";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadTrainingFile
            // 
            this.btnLoadTrainingFile.Location = new System.Drawing.Point(8, 6);
            this.btnLoadTrainingFile.Name = "btnLoadTrainingFile";
            this.btnLoadTrainingFile.Size = new System.Drawing.Size(172, 23);
            this.btnLoadTrainingFile.TabIndex = 5;
            this.btnLoadTrainingFile.Text = "Загрузить файл тренировок";
            this.btnLoadTrainingFile.UseVisualStyleBackColor = true;
            this.btnLoadTrainingFile.Click += new System.EventHandler(this.btnLoadTrainingFile_Click);
            // 
            // dataTrainingGridView
            // 
            this.dataTrainingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTrainingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrainingGridView.Location = new System.Drawing.Point(8, 35);
            this.dataTrainingGridView.Name = "dataTrainingGridView";
            this.dataTrainingGridView.Size = new System.Drawing.Size(829, 216);
            this.dataTrainingGridView.TabIndex = 6;
            // 
            // btnLoadRateFile
            // 
            this.btnLoadRateFile.Location = new System.Drawing.Point(8, 6);
            this.btnLoadRateFile.Name = "btnLoadRateFile";
            this.btnLoadRateFile.Size = new System.Drawing.Size(172, 23);
            this.btnLoadRateFile.TabIndex = 6;
            this.btnLoadRateFile.Text = "Загрузить файл курса валют";
            this.btnLoadRateFile.UseVisualStyleBackColor = true;
            this.btnLoadRateFile.Click += new System.EventHandler(this.btnLoadRateFile_Click);
            // 
            // dataRateGridView
            // 
            this.dataRateGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRateGridView.Location = new System.Drawing.Point(9, 35);
            this.dataRateGridView.Name = "dataRateGridView";
            this.dataRateGridView.Size = new System.Drawing.Size(861, 200);
            this.dataRateGridView.TabIndex = 7;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 686);
            this.Controls.Add(this.tabControl);
            this.Name = "DataView";
            this.Text = "DataView";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataTrainingGridView;
        private System.Windows.Forms.Button btnLoadTrainingFile;
        private System.Windows.Forms.DataGridView dataRateGridView;
        private System.Windows.Forms.Button btnLoadRateFile;
    }
}