namespace ClientWCF
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
            this.textPath = new System.Windows.Forms.TextBox();
            this.textEveniment = new System.Windows.Forms.TextBox();
            this.textPersoane = new System.Windows.Forms.TextBox();
            this.textPeisaje = new System.Windows.Forms.TextBox();
            this.textLocatie = new System.Windows.Forms.TextBox();
            this.butonOpen = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelEveniment = new System.Windows.Forms.Label();
            this.labelPersoane = new System.Windows.Forms.Label();
            this.labelPeisaje = new System.Windows.Forms.Label();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.labelAltele = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(471, 240);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(0, 265);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(222, 20);
            this.textPath.TabIndex = 1;
            this.textPath.TextChanged += new System.EventHandler(this.textPath_TextChanged);
            // 
            // textEveniment
            // 
            this.textEveniment.Location = new System.Drawing.Point(606, 29);
            this.textEveniment.Name = "textEveniment";
            this.textEveniment.Size = new System.Drawing.Size(140, 20);
            this.textEveniment.TabIndex = 2;
            // 
            // textPersoane
            // 
            this.textPersoane.Location = new System.Drawing.Point(606, 78);
            this.textPersoane.Name = "textPersoane";
            this.textPersoane.Size = new System.Drawing.Size(140, 20);
            this.textPersoane.TabIndex = 3;
            // 
            // textPeisaje
            // 
            this.textPeisaje.Location = new System.Drawing.Point(606, 129);
            this.textPeisaje.Name = "textPeisaje";
            this.textPeisaje.Size = new System.Drawing.Size(140, 20);
            this.textPeisaje.TabIndex = 4;
            // 
            // textLocatie
            // 
            this.textLocatie.Location = new System.Drawing.Point(606, 182);
            this.textLocatie.Name = "textLocatie";
            this.textLocatie.Size = new System.Drawing.Size(140, 20);
            this.textLocatie.TabIndex = 5;
            // 
            // butonOpen
            // 
            this.butonOpen.Location = new System.Drawing.Point(13, 311);
            this.butonOpen.Name = "butonOpen";
            this.butonOpen.Size = new System.Drawing.Size(75, 23);
            this.butonOpen.TabIndex = 6;
            this.butonOpen.Text = "Open";
            this.butonOpen.UseVisualStyleBackColor = true;
            this.butonOpen.Click += new System.EventHandler(this.butonOpen_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(137, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(298, 311);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(298, 265);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelEveniment
            // 
            this.labelEveniment.AutoSize = true;
            this.labelEveniment.Location = new System.Drawing.Point(606, 13);
            this.labelEveniment.Name = "labelEveniment";
            this.labelEveniment.Size = new System.Drawing.Size(57, 13);
            this.labelEveniment.TabIndex = 10;
            this.labelEveniment.Text = "Eveniment";
            // 
            // labelPersoane
            // 
            this.labelPersoane.AutoSize = true;
            this.labelPersoane.Location = new System.Drawing.Point(606, 62);
            this.labelPersoane.Name = "labelPersoane";
            this.labelPersoane.Size = new System.Drawing.Size(52, 13);
            this.labelPersoane.TabIndex = 11;
            this.labelPersoane.Text = "Persoane";
            // 
            // labelPeisaje
            // 
            this.labelPeisaje.AutoSize = true;
            this.labelPeisaje.Location = new System.Drawing.Point(606, 113);
            this.labelPeisaje.Name = "labelPeisaje";
            this.labelPeisaje.Size = new System.Drawing.Size(41, 13);
            this.labelPeisaje.TabIndex = 12;
            this.labelPeisaje.Text = "Peisaje";
            this.labelPeisaje.UseWaitCursor = true;
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(606, 166);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(42, 13);
            this.labelLocatie.TabIndex = 13;
            this.labelLocatie.Text = "Locatie";
            // 
            // labelAltele
            // 
            this.labelAltele.AutoSize = true;
            this.labelAltele.Location = new System.Drawing.Point(606, 228);
            this.labelAltele.Name = "labelAltele";
            this.labelAltele.Size = new System.Drawing.Size(33, 13);
            this.labelAltele.TabIndex = 14;
            this.labelAltele.Text = "Altele";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAltele);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.labelPeisaje);
            this.Controls.Add(this.labelPersoane);
            this.Controls.Add(this.labelEveniment);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.butonOpen);
            this.Controls.Add(this.textLocatie);
            this.Controls.Add(this.textPeisaje);
            this.Controls.Add(this.textPersoane);
            this.Controls.Add(this.textEveniment);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textEveniment;
        private System.Windows.Forms.TextBox textPersoane;
        private System.Windows.Forms.TextBox textPeisaje;
        private System.Windows.Forms.TextBox textLocatie;
        private System.Windows.Forms.Button butonOpen;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelEveniment;
        private System.Windows.Forms.Label labelPersoane;
        private System.Windows.Forms.Label labelPeisaje;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Label labelAltele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

