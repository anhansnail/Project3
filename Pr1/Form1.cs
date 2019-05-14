using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Changed {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Created {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Deleted {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            //đây là even sửa tên
            //nếu sửa tên file/thư mục trong path đã đặt thì sẽ hiện lên 1 cái messagebox thông báo
            //tương tự với mấy cái trên

            MessageBox.Show(string.Format("File_Renamed {0} {1}", e.FullPath, e.Name));
        }
    }
}
