using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using System.Text;
using RoboNewser.Code.DAL;

namespace GBN.Web.UI.Admin.DataResources
{
    public partial class TestKeyword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int Counter = 0;
            //PersianWordsDataContext dc = new PersianWordsDataContext();
            //PersianWords NewWord;
            //String[] strFile = File.ReadAllLines(@"E:\Temp\Collection UNI.txt", Encoding.UTF8);
            //foreach (string curLine in strFile)
            //{
            //    if (Counter > 10000)
            //    {
            //        NewWord = new PersianWords();
            //        int index = curLine.LastIndexOf("  ");
            //        string WordType = curLine.Substring(index + 2);
            //        string Word = curLine.Substring(0, index).Trim();
            //        NewWord.Word = Word;
            //        NewWord.WordType = WordType;

            //        dc.PersianWords.InsertOnSubmit(NewWord);
            //        //string[]
            //        //Console.WriteLine(curLine);
            //        dc.SubmitChanges();
            //    }
            //    Counter++;
            //    if (Counter >= 100000)
            //        break;
            //}
            //Response.Write(Counter);
        }
        private string ExtractKeywords(string NewsContent)
        {
            Tools tools = new Tools();
            ArrayList OneLenList = tools.GenLenKeywords(1, 2, @"(\w+)(\w+)", NewsContent);
            ArrayList TwoLenList = tools.GenLenKeywords(2, 2, @"(\w+)(\w+)", NewsContent);
            ArrayList TreeLenList = tools.GenLenKeywords(3, 1, @"(\w+)(\w+)", NewsContent);
            ArrayList FourLenList = tools.GenLenKeywords(4, 1, @"(\w+)(\w+)", NewsContent);
            List<String> FinalKeywords = new List<String>();

            string[] OneLenListArray = (String[])OneLenList.ToArray(typeof(string));
            string[] TwoLenListArray = (String[])TwoLenList.ToArray(typeof(string));
            string[] TreeLenListArray = (String[])TreeLenList.ToArray(typeof(string));
            string[] FourLenListArray = (String[])FourLenList.ToArray(typeof(string));

            IEnumerable<String> TempFullKeyList;
            //TempFullKeyList = OneLenListArray.Union(TwoLenListArray).Union(TreeLenListArray).Union(FourLenListArray);
            TempFullKeyList = FourLenListArray.Union(TreeLenListArray).Union(TwoLenListArray).Union(OneLenListArray);
            for (int j = 0; j < TempFullKeyList.Count(); j++)
            {
                string CurrentKeyword = TempFullKeyList.ElementAt(j);
                IEnumerable<String> ContainList = TempFullKeyList.Where(p => p.Contains(CurrentKeyword));
                if(!CurrentKeyword.Contains(" "))
                    FinalKeywords.Add(CurrentKeyword);
                else if (ContainList.Count() == 1 || !CurrentKeyword.Contains(" "))
                    FinalKeywords.Add(ContainList.ElementAt(0));

            }
            rptKeywords.DataSource = FinalKeywords;
            rptKeywords.DataBind();

            //return Tools.GetkeywordCodes(FinalKeywords);
            return "";


        }

        protected void btnGenKeywords_Click(object sender, EventArgs e)
        {
            string NewsContent = TextBox1.Text;
            string aa = ExtractKeywords(NewsContent);
        }
    }
}
