namespace WOTC_State_Batch_Configurator
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
			System.Windows.Forms.Button btnClearList;
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxState = new System.Windows.Forms.ListBox();
			this.lblListBoxState = new System.Windows.Forms.Label();
			this.btnDeleteVariable = new System.Windows.Forms.Button();
			this.btnAddVariable = new System.Windows.Forms.Button();
			this.lblVariableLength = new System.Windows.Forms.Label();
			this.txtBoxVariableLength = new System.Windows.Forms.TextBox();
			this.listBoxVariableType = new System.Windows.Forms.ListBox();
			this.lblVariableType = new System.Windows.Forms.Label();
			this.txtBxVariableName = new System.Windows.Forms.TextBox();
			this.lblVariableName = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.txtBxPosition = new System.Windows.Forms.TextBox();
			this.lblVariableList = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			btnClearList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClearList
			// 
			btnClearList.Location = new System.Drawing.Point(26, 197);
			btnClearList.Name = "btnClearList";
			btnClearList.Size = new System.Drawing.Size(102, 23);
			btnClearList.TabIndex = 8;
			btnClearList.Text = "Clear List";
			btnClearList.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBoxState);
			this.splitContainer1.Panel1.Controls.Add(this.lblListBoxState);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.checkedListBox1);
			this.splitContainer1.Panel2.Controls.Add(this.lblVariableList);
			this.splitContainer1.Panel2.Controls.Add(this.txtBxPosition);
			this.splitContainer1.Panel2.Controls.Add(this.lblPosition);
			this.splitContainer1.Panel2.Controls.Add(btnClearList);
			this.splitContainer1.Panel2.Controls.Add(this.btnDeleteVariable);
			this.splitContainer1.Panel2.Controls.Add(this.btnAddVariable);
			this.splitContainer1.Panel2.Controls.Add(this.lblVariableLength);
			this.splitContainer1.Panel2.Controls.Add(this.txtBoxVariableLength);
			this.splitContainer1.Panel2.Controls.Add(this.listBoxVariableType);
			this.splitContainer1.Panel2.Controls.Add(this.lblVariableType);
			this.splitContainer1.Panel2.Controls.Add(this.txtBxVariableName);
			this.splitContainer1.Panel2.Controls.Add(this.lblVariableName);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 178;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBoxState
			// 
			this.listBoxState.FormattingEnabled = true;
			this.listBoxState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DC",
            "DE",
            "FL",
            "GA",
            "GU",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VI",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
			this.listBoxState.Location = new System.Drawing.Point(15, 58);
			this.listBoxState.Name = "listBoxState";
			this.listBoxState.Size = new System.Drawing.Size(144, 368);
			this.listBoxState.TabIndex = 1;
			// 
			// lblListBoxState
			// 
			this.lblListBoxState.AutoSize = true;
			this.lblListBoxState.Location = new System.Drawing.Point(13, 32);
			this.lblListBoxState.Name = "lblListBoxState";
			this.lblListBoxState.Size = new System.Drawing.Size(35, 13);
			this.lblListBoxState.TabIndex = 0;
			this.lblListBoxState.Text = "State:";
			// 
			// btnDeleteVariable
			// 
			this.btnDeleteVariable.Location = new System.Drawing.Point(26, 169);
			this.btnDeleteVariable.Name = "btnDeleteVariable";
			this.btnDeleteVariable.Size = new System.Drawing.Size(102, 23);
			this.btnDeleteVariable.TabIndex = 7;
			this.btnDeleteVariable.Text = "Delete Variable";
			this.btnDeleteVariable.UseVisualStyleBackColor = true;
			// 
			// btnAddVariable
			// 
			this.btnAddVariable.Location = new System.Drawing.Point(26, 141);
			this.btnAddVariable.Name = "btnAddVariable";
			this.btnAddVariable.Size = new System.Drawing.Size(102, 23);
			this.btnAddVariable.TabIndex = 6;
			this.btnAddVariable.Text = "Add Variable";
			this.btnAddVariable.UseVisualStyleBackColor = true;
			this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
			// 
			// lblVariableLength
			// 
			this.lblVariableLength.AutoSize = true;
			this.lblVariableLength.Location = new System.Drawing.Point(26, 91);
			this.lblVariableLength.Name = "lblVariableLength";
			this.lblVariableLength.Size = new System.Drawing.Size(81, 13);
			this.lblVariableLength.TabIndex = 5;
			this.lblVariableLength.Text = "Variable Length";
			// 
			// txtBoxVariableLength
			// 
			this.txtBoxVariableLength.Location = new System.Drawing.Point(26, 109);
			this.txtBoxVariableLength.Name = "txtBoxVariableLength";
			this.txtBoxVariableLength.Size = new System.Drawing.Size(100, 20);
			this.txtBoxVariableLength.TabIndex = 4;
			// 
			// listBoxVariableType
			// 
			this.listBoxVariableType.FormattingEnabled = true;
			this.listBoxVariableType.Items.AddRange(new object[] {
            "text",
            "number (1, 2, 3, etc)",
            "decimal (1.00)"});
			this.listBoxVariableType.Location = new System.Drawing.Point(161, 109);
			this.listBoxVariableType.Name = "listBoxVariableType";
			this.listBoxVariableType.Size = new System.Drawing.Size(120, 69);
			this.listBoxVariableType.TabIndex = 3;
			this.listBoxVariableType.SelectedIndexChanged += new System.EventHandler(this.listBoxVariableType_SelectedIndexChanged);
			// 
			// lblVariableType
			// 
			this.lblVariableType.AutoSize = true;
			this.lblVariableType.Location = new System.Drawing.Point(161, 91);
			this.lblVariableType.Name = "lblVariableType";
			this.lblVariableType.Size = new System.Drawing.Size(72, 13);
			this.lblVariableType.TabIndex = 2;
			this.lblVariableType.Text = "Variable Type";
			// 
			// txtBxVariableName
			// 
			this.txtBxVariableName.Location = new System.Drawing.Point(26, 60);
			this.txtBxVariableName.Name = "txtBxVariableName";
			this.txtBxVariableName.Size = new System.Drawing.Size(100, 20);
			this.txtBxVariableName.TabIndex = 1;
			// 
			// lblVariableName
			// 
			this.lblVariableName.AutoSize = true;
			this.lblVariableName.Location = new System.Drawing.Point(26, 42);
			this.lblVariableName.Name = "lblVariableName";
			this.lblVariableName.Size = new System.Drawing.Size(76, 13);
			this.lblVariableName.TabIndex = 0;
			this.lblVariableName.Text = "Variable Name";
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(156, 42);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(44, 13);
			this.lblPosition.TabIndex = 9;
			this.lblPosition.Text = "Position";
			// 
			// txtBxPosition
			// 
			this.txtBxPosition.Location = new System.Drawing.Point(159, 60);
			this.txtBxPosition.Name = "txtBxPosition";
			this.txtBxPosition.Size = new System.Drawing.Size(100, 20);
			this.txtBxPosition.TabIndex = 10;
			// 
			// lblVariableList
			// 
			this.lblVariableList.AutoSize = true;
			this.lblVariableList.Location = new System.Drawing.Point(333, 42);
			this.lblVariableList.Name = "lblVariableList";
			this.lblVariableList.Size = new System.Drawing.Size(64, 13);
			this.lblVariableList.TabIndex = 11;
			this.lblVariableList.Text = "Variable List";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(336, 58);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(120, 244);
			this.checkedListBox1.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "WOTC Batch State Configrator";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxState;
		private System.Windows.Forms.Label lblListBoxState;
		private System.Windows.Forms.Label lblVariableLength;
		private System.Windows.Forms.TextBox txtBoxVariableLength;
		private System.Windows.Forms.ListBox listBoxVariableType;
		private System.Windows.Forms.Label lblVariableType;
		private System.Windows.Forms.TextBox txtBxVariableName;
		private System.Windows.Forms.Label lblVariableName;
		private System.Windows.Forms.Button btnDeleteVariable;
		private System.Windows.Forms.Button btnAddVariable;
		private System.Windows.Forms.TextBox txtBxPosition;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label lblVariableList;
	}
}

