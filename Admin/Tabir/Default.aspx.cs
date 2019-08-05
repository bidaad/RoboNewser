using Parsetv91._1.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Admin.Tabir
{
    public partial class Default : System.Web.UI.Page
    {
        int MainCounter = 3000;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCorrectYa_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            TabirDataContext dc = new TabirDataContext();
            var Result = dc.Tabirs;
            foreach (var item in Result)
            {
                string CurWordName = item.WordName;
                CurWordName = Tools.PersianTextCorrection(CurWordName);
                item.WordName = CurWordName;
                Counter++;
            }
            dc.SubmitChanges();

            lblMessage.Text = Counter + " words corrected";
        }

        protected void btnRemoveDuplicates_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            TabirDataContext dc = new TabirDataContext();
            var Result = dc.Tabirs.OrderBy(p=> p.WordName);
            foreach (var item in Result)
            {
                string CurWordName = item.WordName;
                if (GetTabirCount(CurWordName) > 1)
                {
                    //DeleteTabir(item.Code);
                    dc.Tabirs.DeleteOnSubmit(item);
                }
                Counter++;
            }
            dc.SubmitChanges();
            lblMessage.Text = Counter + " words corrected";
        }

        private void DeleteTabir(int Code)
        {
            TabirDataContext dc = new TabirDataContext();
            Parsetv91._1.Code.DAL.Tabir CurRecord = dc.Tabirs.Single(p => p.Code.Equals(Code));
            dc.Tabirs.DeleteOnSubmit(CurRecord);
            dc.SubmitChanges();
        }

        private int GetTabirCount(string CurWordName)
        {
            TabirDataContext dc = new TabirDataContext();
            return dc.Tabirs.Where(p => p.WordName.Equals(CurWordName)).Count();
        }

        protected void btnakairan_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            ReqUtils Reqs = new ReqUtils();


            string Params = "-a.html,-b.html,-p.html,-t.html,-se.html,-j.html,-ch.html,-h.html,-kh.html,-d.html-zal.html,-r.html,-z.html,24263.html,-sin.html,-shin.html,-sad.html,-zad.html,-ta.html,-za.html,-eyn.html,-ghein.html,-f.html-gh.html,-k.html,-g.html,-l.html,-m.html,-n.html,-v.html,-he.html,-ye.html";
            string[] ParamsArray = Params.Split(',');
            for (int i = 0; i < ParamsArray.Length; i++)
            {
                string CurUrl = "";
                if(ParamsArray[i] == "")
                    CurUrl = "http://tabirkhab.akairan.com/sleep/sleep/";
                else
                    CurUrl = "http://tabirkhab.akairan.com/sleep/sleep/jadval" + ParamsArray[i];
                string Result = Reqs.GetHTML(CurUrl, System.Text.Encoding.UTF8);
                string _pattern = @"<td class=""buttmtbl""><a href=""(.*?)"">(.*?)</a></td>";
                Regex r = new Regex(_pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(Result);
                while (m.Success)
                {
                    Title = m.Groups[2].Captures[0].ToString();
                    Title = Tools.PersianTextCorrection(Title);
                    if (GetTabirCount(Title) == 0)
                    {
                        string TabirUrl = m.Groups[1].Captures[0].ToString();
                        SaveTabir(Title, TabirUrl);
                        Counter++;
                    }
                    m = m.NextMatch();
                }
                lblMessage.Text = Counter + " Tabirs added";

            }
        }

        private void SaveTabir(string WordName, string TabirUrl)
        {
            ReqUtils Reqs = new ReqUtils();
            TabirUrl = TabirUrl.Replace("\" target=\"_blank", "");
            string Result = Reqs.GetHTML(TabirUrl, System.Text.Encoding.UTF8);
            string _pattern = @" class=""contentpaneopen_text"">\s*(.*?)</div>";
            Regex r = new Regex(_pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(Result);
            if (m.Success)
            {
                string Meaning = m.Groups[1].Captures[0].ToString();
                Meaning = Reqs.RemoveTags(Meaning);

                TabirDataContext dc = new TabirDataContext();
                Parsetv91._1.Code.DAL.Tabir NewRecord = new Code.DAL.Tabir();
                dc.Tabirs.InsertOnSubmit(NewRecord);
                NewRecord.WordName = WordName;
                NewRecord.Meaning = Meaning;
                NewRecord.ID = MainCounter.ToString();
                MainCounter++;
                dc.SubmitChanges();

            }
        }

    }
}