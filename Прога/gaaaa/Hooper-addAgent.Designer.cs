
namespace gaaaa
{
    partial class Form2
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(134, 79);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 24);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(152, 176);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(54, 24);
            iNNLabel.TabIndex = 11;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(153, 215);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(53, 24);
            kPPLabel.TabIndex = 13;
            kPPLabel.Text = "КПП:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityLabel.Location = new System.Drawing.Point(92, 250);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(114, 24);
            priorityLabel.TabIndex = 19;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(57, 119);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(149, 24);
            titleLabel.TabIndex = 21;
            titleLabel.Text = "Наименование:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel1.Location = new System.Drawing.Point(174, 287);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(32, 24);
            iDLabel1.TabIndex = 23;
            iDLabel1.Text = "ID:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel1.Location = new System.Drawing.Point(156, 320);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(50, 24);
            titleLabel1.TabIndex = 27;
            titleLabel1.Text = "Title:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(174, 41);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(32, 24);
            iDLabel.TabIndex = 32;
            iDLabel.Text = "ID:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(296, 74);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(140, 29);
            this.addressTextBox.TabIndex = 2;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(gaaaa.Agent);
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNTextBox.Location = new System.Drawing.Point(295, 171);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(140, 29);
            this.iNNTextBox.TabIndex = 12;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kPPTextBox.Location = new System.Drawing.Point(295, 210);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(140, 29);
            this.kPPTextBox.TabIndex = 14;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityTextBox.Location = new System.Drawing.Point(295, 245);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(140, 29);
            this.priorityTextBox.TabIndex = 20;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(296, 114);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(140, 29);
            this.titleTextBox.TabIndex = 22;
            // 
            // iDTextBox1
            // 
            this.iDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentType.ID", true));
            this.iDTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox1.Location = new System.Drawing.Point(295, 282);
            this.iDTextBox1.Name = "iDTextBox1";
            this.iDTextBox1.Size = new System.Drawing.Size(109, 29);
            this.iDTextBox1.TabIndex = 24;
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentType.Title", true));
            this.titleTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox1.Location = new System.Drawing.Point(295, 317);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(109, 29);
            this.titleTextBox1.TabIndex = 28;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(389, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 39);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(76, 379);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 39);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(296, 36);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(108, 29);
            this.iDTextBox.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 467);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDTextBox1);
            this.Controls.Add(titleLabel1);
            this.Controls.Add(this.titleTextBox1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Добавить агента";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox iDTextBox1;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}