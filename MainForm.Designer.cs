namespace NetScope
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            cmbInterfaces = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnStart = new ToolStripButton();
            btnStop = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            txtFilter = new ToolStripTextBox();
            splitContainer1 = new SplitContainer();
            dgvPackets = new DataGridView();
            tvPacketDetail = new TreeView();
            colNumber = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colSrcIp = new DataGridViewTextBoxColumn();
            colDstIp = new DataGridViewTextBoxColumn();
            colProtocol = new DataGridViewTextBoxColumn();
            colLength = new DataGridViewTextBoxColumn();
            colInfo = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackets).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, cmbInterfaces, toolStripSeparator1, btnStart, btnStop, toolStripSeparator2, toolStripLabel2, txtFilter });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1184, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(56, 22);
            toolStripLabel1.Text = "Interface:";
            // 
            // cmbInterfaces
            // 
            cmbInterfaces.DropDownWidth = 300;
            cmbInterfaces.Name = "cmbInterfaces";
            cmbInterfaces.Size = new Size(300, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnStart
            // 
            btnStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStart.Image = (Image)resources.GetObject("btnStart.Image");
            btnStart.ImageTransparentColor = Color.Magenta;
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(23, 22);
            btnStart.Text = "Start";
            // 
            // btnStop
            // 
            btnStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.ImageTransparentColor = Color.Magenta;
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(23, 22);
            btnStop.Text = "Stop";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(36, 22);
            toolStripLabel2.Text = "Filter:";
            // 
            // txtFilter
            // 
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(200, 25);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPackets);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tvPacketDetail);
            splitContainer1.Size = new Size(1184, 686);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 1;
            // 
            // dgvPackets
            // 
            dgvPackets.AllowUserToAddRows = false;
            dgvPackets.AllowUserToDeleteRows = false;
            dgvPackets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackets.Columns.AddRange(new DataGridViewColumn[] { colNumber, colTime, colSrcIp, colDstIp, colProtocol, colLength, colInfo });
            dgvPackets.Dock = DockStyle.Fill;
            dgvPackets.Location = new Point(0, 0);
            dgvPackets.MultiSelect = false;
            dgvPackets.Name = "dgvPackets";
            dgvPackets.ReadOnly = true;
            dgvPackets.RowHeadersVisible = false;
            dgvPackets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackets.Size = new Size(1184, 400);
            dgvPackets.TabIndex = 0;
            // 
            // tvPacketDetail
            // 
            tvPacketDetail.Dock = DockStyle.Fill;
            tvPacketDetail.Location = new Point(0, 0);
            tvPacketDetail.Name = "tvPacketDetail";
            tvPacketDetail.Size = new Size(1184, 282);
            tvPacketDetail.TabIndex = 0;
            // 
            // colNumber
            // 
            colNumber.HeaderText = "No.";
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.Width = 60;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colSrcIp
            // 
            colSrcIp.HeaderText = "Source IP";
            colSrcIp.Name = "colSrcIp";
            colSrcIp.ReadOnly = true;
            colSrcIp.Width = 130;
            // 
            // colDstIp
            // 
            colDstIp.HeaderText = "Destination IP";
            colDstIp.Name = "colDstIp";
            colDstIp.ReadOnly = true;
            colDstIp.Width = 130;
            // 
            // colProtocol
            // 
            colProtocol.HeaderText = "Protocol";
            colProtocol.Name = "colProtocol";
            colProtocol.ReadOnly = true;
            // 
            // colLength
            // 
            colLength.HeaderText = "Length";
            colLength.Name = "colLength";
            colLength.ReadOnly = true;
            colLength.Width = 70;
            // 
            // colInfo
            // 
            colInfo.HeaderText = "Info";
            colInfo.Name = "colInfo";
            colInfo.ReadOnly = true;
            colInfo.Width = 400;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NetScope";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPackets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cmbInterfaces;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnStart;
        private ToolStripButton btnStop;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtFilter;
        private SplitContainer splitContainer1;
        private DataGridView dgvPackets;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colSrcIp;
        private DataGridViewTextBoxColumn colDstIp;
        private DataGridViewTextBoxColumn colProtocol;
        private DataGridViewTextBoxColumn colLength;
        private DataGridViewTextBoxColumn colInfo;
        private TreeView tvPacketDetail;
    }
}
