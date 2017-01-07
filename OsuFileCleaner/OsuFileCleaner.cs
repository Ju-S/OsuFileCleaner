using System;
using System.Windows.Forms;

namespace OsuFileCleaner
{
    public partial class OsuFileCleaner : Form
    {
        public OsuFileCleaner()
        {
            InitializeComponent();
        }

        private void OsuFileDeleter_Load(object sender, EventArgs e)
        {
            CleanOption.SelectedIndex = 0;  //초기옵션 설정
        }

        private void CleanOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = null;  //포커스지우기
            CleanButton.Text = "정리";
        }

        private void FileSelecter_Click(object sender, EventArgs e)  //파일선택
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            file.ShowDialog();
            FilePath.Text = file.SelectedPath;
            if (file.SelectedPath != "")  //파일선택시 정리버튼 활성화
                CleanButton.Enabled = true;
            CleanButton.Text = "정리";
        }

        private void CleanButton_Click(object sender, EventArgs e)  //파일정리
        {  //Deleter클래스를 이용한 파일정리 인자로는 song경로와 정리규칙
            CleanButton.Text = "정리";
            string question = "정말 Osu의 Songs폴더가 맞습니까?";
            DialogResult dialog =
                MessageBox.Show(question, FilePath.Text, MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Cleaner deleter = new Cleaner(FilePath.Text, CleanOption.SelectedIndex);
                deleter.Delete();  //파일정리
                CleanButton.Text = "완료";
            }
        }
    }
}
