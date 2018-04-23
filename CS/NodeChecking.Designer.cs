namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class NodeChecking {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeChecking));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(4, 27);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(543, 269);
            this.treeList1.StateImageList = this.imageList1;
            this.treeList1.TabIndex = 6;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Press the space key or click a state image to check a node.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NodeChecking
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.label3);
            this.Name = "NodeChecking";
            this.Size = new System.Drawing.Size(551, 300);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.IContainer components;

    }
}
