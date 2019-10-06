using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Genesis
{
    public partial class ADTree : UserControl
    {
        public ADTree()
        {
             InitializeComponent();
             DirectoryEntry ADentry = new DirectoryEntry("LDAP://192.168.0.15/DC=nova,DC=local", "administrator", "Letmein123!");

             DirectorySearcher Searcher = new DirectorySearcher(ADentry);
             Searcher.Filter = ("(objectClass=*)");  // Search all.
           

             // The first item in the results is always the domain. Therefore, we just get that and retrieve its children.
             foreach (DirectoryEntry entry in Searcher.FindOne().GetDirectoryEntry().Children)
             {
                 if (ShouldAddNode(entry.SchemaClassName))
                     treeView1.Nodes.Add(GetChildNode(entry));
             }
            
        }

        private TreeNode GetChildNode(DirectoryEntry entry)
        {
            TreeNode node = new TreeNode(entry.Name.Substring(entry.Name.IndexOf('=') + 1));

            foreach (DirectoryEntry childEntry in entry.Children)
            {
                if (ShouldAddNode(childEntry.SchemaClassName))
                    node.Nodes.Add(GetChildNode(childEntry));
            }

            return node;
        }

        private bool ShouldAddNode(string childEntryType)
        {
            bool shouldAdd = false;
            switch (childEntryType)
            {
                case "organizationalUnit":
                    shouldAdd = true;
                    break;
                case "group":
                    shouldAdd = true;
                    break;
                case "computer":
                    shouldAdd = true;
                    break;
                case "contact":
                    shouldAdd = true;
                    break;
                case "user":
                    shouldAdd = true;
                    break;
                case "container":
                    shouldAdd = true;
                    break;
               /* case "builtinDomain":
                    shouldAdd = true;
                    break;*/
                default:
                    shouldAdd = false;
                    break;

            }
            return shouldAdd;
        }
    }
}
