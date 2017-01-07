using System.Text.RegularExpressions;

namespace OsuFileCleaner
{
    class Inspector  //검사기
    {
        string Name { get; set; }  //검사할 파일명
        bool chk;  //검사결과
        #region 검사규칙
        string[] regex =
            { @".*(?=\.osu)", @".*(?=\.[af][vl][iv])", @".*(?=\.wav)", @".*(?=\.jpg)", @".*(?=\.png)" };
        #endregion
        Regex selectedRegex;

        public Inspector(int selectedRegexNum)  //해당 검사규칙을 입력
        {
            selectedRegex = new Regex(regex[selectedRegexNum]);
        }

        public bool Inspect(string name)  //파일명 설정후 검사
        {
            Name = name;
            if (Name != "")
                chk = selectedRegex.IsMatch(Name);  //검사결과
            return chk;
        }
    }
}
