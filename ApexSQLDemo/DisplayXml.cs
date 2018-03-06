using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace ApexSQLDemo
{
    public partial class frmDisplayXml : Form
    {
        public frmDisplayXml()
        {
            InitializeComponent();
        }

        private void btnCreateXml_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtFolderName.Text))
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DirectoryInfo dir = new DirectoryInfo(txtFolderName.Text);
                    var doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), CreateXmlFile(dir));
                    doc.Save(SaveFileDialog.FileName);
                    Cursor.Current = Cursors.Default;
                }
            }
            else MessageBox.Show("Folder name is not a valid."); 
        }

        private static XElement CreateXmlFile(DirectoryInfo dir)
        {
            //get directories
            var xmlInfo = new XElement("folder",
                new XElement("name", dir.Name),
                new XElement("size", GetDirectorySize(dir)),
                new XElement("numoffiles", dir.GetFiles().Length));

            //get subdirectories
            foreach (var subDir in dir.GetDirectories())
            {
                xmlInfo.Add(CreateXmlFile(subDir));
            }

            //get all the files
            foreach (var file in dir.GetFiles())
            {
                xmlInfo.Add(new XElement("file",
                    new XElement("name", file.Name),
                    new XElement("size", file.Length),
                    new XElement("creationTime", file.CreationTime),
                    new XElement("lastAccess", file.LastAccessTime),
                    new XElement("lastModify", file.LastWriteTime)));
            }
            return xmlInfo;
            
        }

        private static long GetDirectorySize(DirectoryInfo dir)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = dir.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = dir.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += GetDirectorySize(di);
            }
            return size;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderName.Text = folderBrowserDialog.SelectedPath;
            } 
        }

        private void btnShowXml_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor; 
                    XmlDocument doc = new XmlDocument();
                    doc.Load(OpenFileDialog.FileName);

                    treeView.Nodes.Clear();
                    foreach (XmlNode node in doc)
                    {
                        TreeNode treeNode = XmlNode2TreeNode(node);
                        //GetAttributes(node, treeNode);
                        treeNode.Text = FormatName(node);
                       // treeNode.Text = node.Name;
                        treeView.Nodes.Add(treeNode);
                    }

                    treeView.ExpandAll();
                    Cursor.Current = Cursors.Default;  
                }
                catch (XmlException xmlEx)
                {
                    Cursor.Current = Cursors.Default; 
                    MessageBox.Show(xmlEx.Message);
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default; 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private TreeNode XmlNode2TreeNode(XmlNode parentNode)
        {
            TreeNode treeNode = new TreeNode();

            foreach (XmlNode childNode in parentNode.ChildNodes)
            {
                if (childNode.NodeType == XmlNodeType.Element)
                {
                    TreeNode childTreeNode = new TreeNode();

                    if (childNode.ChildNodes.Count > 0)
                        childTreeNode = XmlNode2TreeNode(childNode);

                    childTreeNode.Text = FormatName(childNode);
                    treeNode.Nodes.Add(childTreeNode);
                }
            }

            return treeNode;
        }

        private string FormatName(XmlNode node)
        {
            string fullName = "<" + node.Name;

            if (node.Name.Contains("folder") || node.Name.Contains("file"))
                fullName += ">";
            else
            {
                if (node.InnerText != "")
                    fullName += ">" + node.InnerText + "</" + node.Name + ">";
                else
                    fullName += ">";
            }
            return fullName;
        }

}
      
    
}
