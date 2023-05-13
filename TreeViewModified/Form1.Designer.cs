namespace TreeViewModified;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        TreeNode treeNode1 = new TreeNode("Customers", 2, 2);
        TreeNode treeNode2 = new TreeNode("Suppliers", 2, 2);
        TreeNode treeNode3 = new TreeNode("Orders", 2, 2);
        TreeNode treeNode4 = new TreeNode("Region", 2, 2);
        TreeNode treeNode5 = new TreeNode("Procurement", 2, 2);
        TreeNode treeNode6 = new TreeNode("Northwind", 1, 1, new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
        TreeNode treeNode7 = new TreeNode("Table0", 2, 2);
        TreeNode treeNode8 = new TreeNode("Table1", 2, 2);
        TreeNode treeNode9 = new TreeNode("Table2", 2, 2);
        TreeNode treeNode10 = new TreeNode("Table3", 2, 2);
        TreeNode treeNode11 = new TreeNode("Master0", 1, 1, new TreeNode[] { treeNode7, treeNode8, treeNode9, treeNode10 });
        TreeNode treeNode12 = new TreeNode("Databases", 0, 0, new TreeNode[] { treeNode6, treeNode11 });
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new Button();
        listView1 = new ListView();
        imageList1 = new ImageList(components);
        button2 = new Button();
        treeViewMS1 = new TreeViewMS.TreeViewMS();
        SuspendLayout();
        // 
        // button1
        // 
        button1.FlatStyle = FlatStyle.Flat;
        button1.Location = new Point(278, 39);
        button1.Name = "button1";
        button1.Size = new Size(125, 50);
        button1.TabIndex = 1;
        button1.Text = "-- Add -->";
        button1.Click += button1_AddNodes;
        // 
        // listView1
        // 
        listView1.Location = new Point(413, 20);
        listView1.Name = "listView1";
        listView1.Size = new Size(240, 246);
        listView1.SmallImageList = imageList1;
        listView1.TabIndex = 2;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.List;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth8Bit;
        imageList1.ImageSize = new Size(16, 16);
        imageList1.TransparentColor = Color.White;
        // 
        // button2
        // 
        button2.FlatStyle = FlatStyle.Flat;
        button2.Location = new Point(278, 108);
        button2.Name = "button2";
        button2.Size = new Size(125, 50);
        button2.TabIndex = 3;
        button2.Text = "<-- Remove --";
        button2.Click += button2_RemoveNodes;
        // 
        // treeViewMS1
        // 
        treeViewMS1.Location = new Point(10, 20);
        treeViewMS1.Name = "treeViewMS1";
        treeNode1.ImageIndex = 2;
        treeNode1.Name = "";
        treeNode1.SelectedImageIndex = 2;
        treeNode1.Text = "Customers";
        treeNode2.ImageIndex = 2;
        treeNode2.Name = "";
        treeNode2.SelectedImageIndex = 2;
        treeNode2.Text = "Suppliers";
        treeNode3.ImageIndex = 2;
        treeNode3.Name = "";
        treeNode3.SelectedImageIndex = 2;
        treeNode3.Text = "Orders";
        treeNode4.ImageIndex = 2;
        treeNode4.Name = "";
        treeNode4.SelectedImageIndex = 2;
        treeNode4.Text = "Region";
        treeNode5.ImageIndex = 2;
        treeNode5.Name = "";
        treeNode5.SelectedImageIndex = 2;
        treeNode5.Text = "Procurement";
        treeNode6.ImageIndex = 1;
        treeNode6.Name = "";
        treeNode6.SelectedImageIndex = 1;
        treeNode6.Text = "Northwind";
        treeNode7.ImageIndex = 2;
        treeNode7.Name = "";
        treeNode7.SelectedImageIndex = 2;
        treeNode7.Text = "Table0";
        treeNode8.ImageIndex = 2;
        treeNode8.Name = "";
        treeNode8.SelectedImageIndex = 2;
        treeNode8.Text = "Table1";
        treeNode9.ImageIndex = 2;
        treeNode9.Name = "";
        treeNode9.SelectedImageIndex = 2;
        treeNode9.Text = "Table2";
        treeNode10.ImageIndex = 2;
        treeNode10.Name = "";
        treeNode10.SelectedImageIndex = 2;
        treeNode10.Text = "Table3";
        treeNode11.ImageIndex = 1;
        treeNode11.Name = "";
        treeNode11.SelectedImageIndex = 1;
        treeNode11.Text = "Master0";
        treeNode12.ImageIndex = 0;
        treeNode12.Name = "";
        treeNode12.SelectedImageIndex = 0;
        treeNode12.Text = "Databases";
        treeViewMS1.Nodes.AddRange(new TreeNode[] { treeNode12 });
        treeViewMS1.SelectedNodes = (System.Collections.ArrayList)resources.GetObject("treeViewMS1.SelectedNodes");
        treeViewMS1.Size = new Size(259, 246);
        treeViewMS1.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleBaseSize = new Size(6, 16);
        ClientSize = new Size(691, 290);
        Controls.Add(treeViewMS1);
        Controls.Add(button2);
        Controls.Add(listView1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Demo App (multiple selection treeview)";
        ResumeLayout(false);
    }
    #endregion



    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Button button2;
    private TreeViewMS.TreeViewMS treeViewMS1;
    //private System.ComponentModel.IContainer components;


}