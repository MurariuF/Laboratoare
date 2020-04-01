namespace GUI
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEveniment = new System.Windows.Forms.TextBox();
            this.textPersoane = new System.Windows.Forms.TextBox();
            this.textPeisaje = new System.Windows.Forms.TextBox();
            this.textLocatie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAltele1 = new System.Windows.Forms.TextBox();
            this.textAltele2 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 235);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(41, 291);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(41, 264);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(207, 20);
            this.textPath.TabIndex = 2;
            this.textPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(72, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eveniment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Persoane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peisaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Locatie";
            // 
            // textEveniment
            // 
            this.textEveniment.Location = new System.Drawing.Point(536, 39);
            this.textEveniment.Name = "textEveniment";
            this.textEveniment.Size = new System.Drawing.Size(134, 20);
            this.textEveniment.TabIndex = 8;
            // 
            // textPersoane
            // 
            this.textPersoane.Location = new System.Drawing.Point(536, 88);
            this.textPersoane.Name = "textPersoane";
            this.textPersoane.Size = new System.Drawing.Size(134, 20);
            this.textPersoane.TabIndex = 9;
            // 
            // textPeisaje
            // 
            this.textPeisaje.Location = new System.Drawing.Point(536, 141);
            this.textPeisaje.Name = "textPeisaje";
            this.textPeisaje.Size = new System.Drawing.Size(134, 20);
            this.textPeisaje.TabIndex = 10;
            // 
            // textLocatie
            // 
            this.textLocatie.Location = new System.Drawing.Point(536, 195);
            this.textLocatie.Name = "textLocatie";
            this.textLocatie.Size = new System.Drawing.Size(134, 20);
            this.textLocatie.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Altele";
            // 
            // textAltele1
            // 
            this.textAltele1.Location = new System.Drawing.Point(535, 247);
            this.textAltele1.Name = "textAltele1";
            this.textAltele1.Size = new System.Drawing.Size(134, 20);
            this.textAltele1.TabIndex = 13;
            // 
            // textAltele2
            // 
            this.textAltele2.Location = new System.Drawing.Point(535, 273);
            this.textAltele2.Name = "textAltele2";
            this.textAltele2.Size = new System.Drawing.Size(134, 20);
            this.textAltele2.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(297, 291);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(297, 260);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textAltele2);
            this.Controls.Add(this.textAltele1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLocatie);
            this.Controls.Add(this.textPeisaje);
            this.Controls.Add(this.textPersoane);
            this.Controls.Add(this.textEveniment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEveniment;
        private System.Windows.Forms.TextBox textPersoane;
        private System.Windows.Forms.TextBox textPeisaje;
        private System.Windows.Forms.TextBox textLocatie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAltele1;
        private System.Windows.Forms.TextBox textAltele2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}

