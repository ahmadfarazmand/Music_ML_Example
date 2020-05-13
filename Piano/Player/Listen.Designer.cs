namespace Piano.Player
{
    partial class Listen
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
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonNewPlay = new System.Windows.Forms.Button();
            this.numericTemplates = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.playType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelRythm = new System.Windows.Forms.Label();
            this.numericTempoValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxScale = new System.Windows.Forms.ListBox();
            this.comboBoxRythm = new System.Windows.Forms.ComboBox();
            this.comboBoxScalePos = new System.Windows.Forms.ComboBox();
            this.comboBoxScaleType = new System.Windows.Forms.ComboBox();
            this.comboBoxScaleNoteOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTempoValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReplay
            // 
            this.buttonReplay.Location = new System.Drawing.Point(268, 160);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(75, 23);
            this.buttonReplay.TabIndex = 1;
            this.buttonReplay.Text = "Replay";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // buttonNewPlay
            // 
            this.buttonNewPlay.Location = new System.Drawing.Point(268, 189);
            this.buttonNewPlay.Name = "buttonNewPlay";
            this.buttonNewPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPlay.TabIndex = 2;
            this.buttonNewPlay.Text = "New Play";
            this.buttonNewPlay.UseVisualStyleBackColor = true;
            this.buttonNewPlay.Click += new System.EventHandler(this.buttonNewPlay_Click);
            // 
            // numericTemplates
            // 
            this.numericTemplates.Location = new System.Drawing.Point(142, 105);
            this.numericTemplates.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericTemplates.Name = "numericTemplates";
            this.numericTemplates.Size = new System.Drawing.Size(120, 20);
            this.numericTemplates.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a template number and play by scales:";
            // 
            // playType
            // 
            this.playType.FormattingEnabled = true;
            this.playType.Location = new System.Drawing.Point(138, 169);
            this.playType.Name = "playType";
            this.playType.Size = new System.Drawing.Size(124, 43);
            this.playType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Template Number:";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(12, 48);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(37, 13);
            this.labelScale.TabIndex = 6;
            this.labelScale.Text = "Scale:";
            // 
            // labelRythm
            // 
            this.labelRythm.AutoSize = true;
            this.labelRythm.Location = new System.Drawing.Point(141, 48);
            this.labelRythm.Name = "labelRythm";
            this.labelRythm.Size = new System.Drawing.Size(46, 13);
            this.labelRythm.TabIndex = 7;
            this.labelRythm.Text = "Rhythm:";
            // 
            // numericTempoValue
            // 
            this.numericTempoValue.Location = new System.Drawing.Point(141, 144);
            this.numericTempoValue.Name = "numericTempoValue";
            this.numericTempoValue.Size = new System.Drawing.Size(50, 20);
            this.numericTempoValue.TabIndex = 8;
            this.numericTempoValue.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericTempoValue.ValueChanged += new System.EventHandler(this.numericTempoValue_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tempo:";
            // 
            // listBoxScale
            // 
            this.listBoxScale.FormattingEnabled = true;
            this.listBoxScale.Location = new System.Drawing.Point(12, 117);
            this.listBoxScale.Name = "listBoxScale";
            this.listBoxScale.Size = new System.Drawing.Size(120, 69);
            this.listBoxScale.TabIndex = 9;
            // 
            // comboBoxRythm
            // 
            this.comboBoxRythm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRythm.FormattingEnabled = true;
            this.comboBoxRythm.Location = new System.Drawing.Point(141, 65);
            this.comboBoxRythm.Name = "comboBoxRythm";
            this.comboBoxRythm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRythm.TabIndex = 10;
            this.comboBoxRythm.SelectedIndexChanged += new System.EventHandler(this.comboBoxRythm_SelectedIndexChanged);
            // 
            // comboBoxScalePos
            // 
            this.comboBoxScalePos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScalePos.FormattingEnabled = true;
            this.comboBoxScalePos.Location = new System.Drawing.Point(11, 91);
            this.comboBoxScalePos.Name = "comboBoxScalePos";
            this.comboBoxScalePos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScalePos.TabIndex = 10;
            this.comboBoxScalePos.SelectedIndexChanged += new System.EventHandler(this.comboBoxScalePos_SelectedIndexChanged);
            // 
            // comboBoxScaleType
            // 
            this.comboBoxScaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScaleType.FormattingEnabled = true;
            this.comboBoxScaleType.Location = new System.Drawing.Point(11, 64);
            this.comboBoxScaleType.Name = "comboBoxScaleType";
            this.comboBoxScaleType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScaleType.TabIndex = 10;
            this.comboBoxScaleType.SelectedIndexChanged += new System.EventHandler(this.comboBoxScaleType_SelectedIndexChanged);
            // 
            // comboBoxScaleNoteOrder
            // 
            this.comboBoxScaleNoteOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScaleNoteOrder.FormattingEnabled = true;
            this.comboBoxScaleNoteOrder.Location = new System.Drawing.Point(11, 191);
            this.comboBoxScaleNoteOrder.Name = "comboBoxScaleNoteOrder";
            this.comboBoxScaleNoteOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScaleNoteOrder.TabIndex = 10;
            this.comboBoxScaleNoteOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Listen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 219);
            this.Controls.Add(this.comboBoxScaleType);
            this.Controls.Add(this.comboBoxScalePos);
            this.Controls.Add(this.comboBoxScaleNoteOrder);
            this.Controls.Add(this.comboBoxRythm);
            this.Controls.Add(this.listBoxScale);
            this.Controls.Add(this.numericTempoValue);
            this.Controls.Add(this.labelRythm);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericTemplates);
            this.Controls.Add(this.buttonNewPlay);
            this.Controls.Add(this.buttonReplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Listen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Listen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTempoValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.Button buttonNewPlay;
        private System.Windows.Forms.NumericUpDown numericTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Label labelRythm;
        private System.Windows.Forms.NumericUpDown numericTempoValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxScale;
        private System.Windows.Forms.ComboBox comboBoxRythm;
        private System.Windows.Forms.ComboBox comboBoxScalePos;
        private System.Windows.Forms.ComboBox comboBoxScaleType;
        private System.Windows.Forms.ComboBox comboBoxScaleNoteOrder;
    }
}