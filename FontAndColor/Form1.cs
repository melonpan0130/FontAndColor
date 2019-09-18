using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontAndColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TsbtnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDlg.ShowDialog(); // font dialog
            switch(result)
            {
                case DialogResult.OK: // OK를 눌렀을 경우
                    // 1. 전체 폰트 바꾸기
                    // this.rtbText.Font = this.fontDlg.Font;
                    // 2. 선택된 영역만 바꾸기
                    this.rtbText.SelectionFont = this.fontDlg.Font;
                    break;
                case DialogResult.Cancel: // Cancel을 눌렀을 경우
                    MessageBox.Show("폰트 변경을 취소하였습니다.", "알림");
                    break;
            }
        }

        private void TsbtnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDlg.ShowDialog(); // color dialog
            switch(result)
            {
                case DialogResult.OK:
                    this.rtbText.SelectionColor = this.colorDlg.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색 변경을 취소하였습니다.", "알람");
                    break;
            }
        }
    }
}
