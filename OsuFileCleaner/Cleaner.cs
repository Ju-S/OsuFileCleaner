using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace OsuFileCleaner
{
    class Cleaner  //정리기
    {
        string SongPath { get; set; }  //song파일경로
        int SelectedRegex { get; set; } //정리규칙
        Inspector inspector;  //파일의 일치여부 검사 클래스

        public Cleaner(string songPath, int selectedRegex)
        {
            SongPath = songPath;
            SelectedRegex = selectedRegex;
            inspector = new Inspector(SelectedRegex);  //검사규칙 입력
        }

        public void Delete()  //정리하기
        {
            string[] Paths;  //정리할 파일 혹은 폴더의 경로

            Paths = FolderFinder();  //경로저장

            if (SelectedRegex != 0)
                foreach (string path in Paths)
                    File.Delete(path);
            else
                foreach (string path in Paths)
                    Directory.Delete(path, true);

            if (SelectedRegex == 3)
                SetOsuIsAngry();  //배경화면 없을시 생기는 경고화면 제거

        }

        private string[] FolderFinder()  //정리할 폴더찾기
        {
            List<string> PathsList = new List<string>();  //정리할 파일 혹은 폴더의 경로
            string[] Paths;

            foreach (string folder in Directory.GetDirectories(SongPath))
            {
                bool folderChk = true;  //쓰레기폴더 확인용

                foreach (string file in Directory.GetFiles(folder, "*", SearchOption.AllDirectories))
                {
                    if (SelectedRegex != 0)  //해당파일 추가
                    {
                        folderChk = false;  //폴더가 아니므로 폴더체크해제
                        if (inspector.Inspect(file))
                            PathsList.Add(file);
                    }
                    else
                    {
                        if (inspector.Inspect(file))  //비트맵이 없는 쓰레기폴더 확인
                        {
                            folderChk = false;  //비트맵이 있을경우 해당 폴더 제외
                            break;
                        }
                    }
                }

                if (folderChk)  //비트맵이 없을경우 삭제리스트에 추가
                    PathsList.Add(folder);
            }

            Paths = PathsList.ToArray();
            return Paths;
        }

        private void SetOsuIsAngry()  //배경화면 없을시 생기는 경고화면 제거
        {
            SongPath = $"{Regex.Replace(SongPath, "Songs", "Localisation")}";  //.txt경로
            foreach (string file in Directory.GetFiles(SongPath, "*"))
            {
                string[] Text = File.ReadAllLines(file);
                for (int i = 0; i < Text.Length; i++)  //경고문구를 제거
                    if (Regex.IsMatch(Text[i], "OsuIsAngry.*"))
                    {
                        Text[i] = Regex.Replace(Text[i], "(?<==).*", "");
                        break;
                    }
                File.WriteAllLines(file, Text);
            }
        }
    }
}
