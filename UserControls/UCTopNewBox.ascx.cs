using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCTopNewBox : System.Web.UI.UserControl
    {
        protected int _catCode;
        public int CatCode
        {
            get
            {
                return _catCode;
            }
            set
            {
                _catCode = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_catCode)
                {
                    case 1:
                        {
                            lblCatTitle.Text = "اجتماعي";
                            break;
                        }
                    case 2:
                        {
                            lblCatTitle.Text = "اقتصادي";
                            break;
                        }
                    case 3:
                        {
                            lblCatTitle.Text = "سياسي";
                            break;
                        }
                    case 4:
                        {
                            lblCatTitle.Text = "ورزشي";
                            break;
                        }
                    case 5:
                        {
                            lblCatTitle.Text = "علمي";
                            break;
                        }
                    case 6:
                        {
                            lblCatTitle.Text = "فرهنگي";
                            break;
                        }
                    case 7:
                        {
                            lblCatTitle.Text = "ادب و هنر";
                            break;
                        }
                    case 8:
                        {
                            lblCatTitle.Text = "بين‌الملل";
                            break;
                        }
                    default:
                        break;
                }

                if (!Page.IsPostBack)
                {
                    hplMore.NavigateUrl = "~/News/NewsByCatCode.aspx?Code=" + _catCode;
                    BOLNews NewsBOL = new BOLNews();
                    IQueryable<vLatestPicNews> CurNewsList = NewsBOL.GetTopPicNews(_catCode);
                    if (CurNewsList.Count() == 1)
                    {
                        vLatestPicNews CurNews = CurNewsList.First();
                        vNewsDetail CurNewsFull = NewsBOL.GetNewsByCode(CurNews.Code);
                        ImgTopNews.ImageUrl = CurNews.ImgUrl;// "~/Files/News/" + CurNews.PicName;
                        hplTopNewsTitle.NavigateUrl = hplTopNews.NavigateUrl = "~/FaNews/" + CurNews.Code + "_" + Tools.ConvertFarsiToPingilish(CurNews.Title) + ".html";
                        hplResource.NavigateUrl = "~/NR" + CurNews.ResouseSiteCode + "_" + Tools.ReplaceSpaceWithUnderline(CurNews.ResourceName) + ".html";
                        hplResource.Text = CurNews.ResourceName;

                        Tools tools = new Tools();
                        hplTopNewsTitle.Text = CurNews.Title;
                        lblTopNewsStory.Text = Tools.ShowBriefText(tools.RemoveTags(CurNewsFull.Contents), 120) + "...";

                        rptNews.DataSource = NewsBOL.GetPicNews(_catCode, CurNews.Code, 4);
                        rptNews.DataBind();
                    }
                }

            }

            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "News_Default::Load");
            }
        }
    }
}