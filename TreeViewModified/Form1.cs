namespace TreeViewModified;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }






    private void button1_AddNodes(object sender, System.EventArgs e)
    {

        // add selected items from treeview to the listview on the right hand side
        foreach (TreeNode n in treeViewMS1.SelectedNodes)
        {
            listView1.Items.Add(n.Text, n.ImageIndex);
        }

    }

    private void button2_RemoveNodes(object sender, System.EventArgs e)
    {
        ListView.SelectedListViewItemCollection selcoll = listView1.SelectedItems;

        while (selcoll.Count > 0)// warning : sellcoll.Count dynamically updated by listView1.Items.Remove(...)
            listView1.Items.Remove(selcoll[0]);
    }


}