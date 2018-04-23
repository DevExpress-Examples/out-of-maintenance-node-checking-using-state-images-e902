using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for NodeChecking.
    /// </summary>
    public partial class NodeChecking : DevExpress.XtraEditors.XtraUserControl {
        public NodeChecking() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            treeList1.SelectImageList = null;
            try {
                SetCheckedNode(treeList1.Nodes[0].Nodes[0]);
            }
            catch { }
        }

        private CheckState GetCheckState(object obj) {
            if(obj != null) return (CheckState)obj;
            return CheckState.Unchecked;
        }
        //<treeList1>
        private void SetCheckedNode(DevExpress.XtraTreeList.Nodes.TreeListNode node) {
            CheckState check = GetCheckState(node.Tag);
            if(check == CheckState.Indeterminate || check == CheckState.Unchecked) check = CheckState.Checked;
            else check = CheckState.Unchecked;
            treeList1.BeginUpdate();
            node.Tag = check;
            SetCheckedChildNodes(node, check);
            SetCheckedParentNodes(node, check);
            treeList1.EndUpdate();
        }
        //</treeList1>

        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check) {
            for(int i = 0; i < node.Nodes.Count; i++) {
                node.Nodes[i].Tag = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check) {
            if(node.ParentNode != null) {
                bool b = false;
                CheckState state;
                for(int i = 0; i < node.ParentNode.Nodes.Count; i++) {
                    if(node.ParentNode.Nodes[i].Tag == null) state = CheckState.Unchecked;
                    else state = (CheckState)node.ParentNode.Nodes[i].Tag;
                    if(!check.Equals(state)) {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.Tag = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        //<treeList1>
        private void treeList1_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e) {
            CheckState check = GetCheckState(e.Node.Tag);
            if(check == CheckState.Unchecked)
                e.NodeImageIndex = 0;
            else if(check == CheckState.Checked)
                e.NodeImageIndex = 1;
            else e.NodeImageIndex = 2;
        }

        private void treeList1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyData == Keys.Space)
                SetCheckedNode(treeList1.FocusedNode);
        }

        private void treeList1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                DevExpress.XtraTreeList.TreeListHitInfo hInfo = treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if(hInfo.HitInfoType == HitInfoType.StateImage)
                    SetCheckedNode(hInfo.Node);
            }
        }
        //</treeList1>
    }
}
