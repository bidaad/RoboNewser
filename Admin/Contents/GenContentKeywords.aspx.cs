using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Parsetv91._1.Code.DAL;

namespace Parsetv91._1.Admin.Contents
{
    public partial class GenContentKeywords : System.Web.UI.Page
    {
        List<String> AdvertiseKeyword;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //BOLEntityKeywords EntityKeywordsBOL = new BOLEntityKeywords();

            //ReqUtils Utils = new ReqUtils();
            //ContentsDataContext dc = new ContentsDataContext();
            //var ContentList = dc.Contents;
            //foreach (var item in ContentList)
            //{
            //    try
            //    {
            //        string CurDesc = item.ContentText;
            //        CurDesc = Utils.RemoveTags(CurDesc);
            //        CurDesc = Tools.PersianTextCorrection(CurDesc);
            //        ExtractKeywords(CurDesc);
            //        string KeywordCodeList = Tools.GetkeywordCodes2(AdvertiseKeyword);
            //        EntityKeywordsBOL.SaveKeywordList(item.Code, KeywordCodeList, 4);
            //    }
            //    catch
            //    {
            //    }

            //}

            //BOLEntityKeywords EntityKeywordsBOL = new BOLEntityKeywords();
            //TabirDataContext dc = new TabirDataContext();

            //ReqUtils Utils = new ReqUtils();
            //var TabirList = dc.Tabirs;
            //foreach (var item in TabirList)
            //{
            //    try
            //    {
            //        string CurDesc = item.Meaning;
            //        CurDesc = Utils.RemoveTags(CurDesc);
            //        CurDesc = Tools.PersianTextCorrection(CurDesc);
            //        ExtractKeywords(CurDesc);
            //        string KeywordCodeList = Tools.GetkeywordCodes2(AdvertiseKeyword);
            //        EntityKeywordsBOL.SaveKeywordList(item.Code, KeywordCodeList, 5);
            //    }
            //    catch
            //    {
            //    }

            //}

            BOLEntityKeywords EntityKeywordsBOL = new BOLEntityKeywords();
            ProductsDataContext dc = new ProductsDataContext();

            ReqUtils Utils = new ReqUtils();
            var ProductList = dc.Products;
            foreach (var item in ProductList)
            {
                try
                {
                    string CurDesc = item.Description;
                    CurDesc = Utils.RemoveTags(CurDesc);
                    CurDesc = Tools.PersianTextCorrection(CurDesc);
                    ExtractKeywords(CurDesc);
                    string KeywordCodeList = Tools.GetkeywordCodes2(AdvertiseKeyword);
                    EntityKeywordsBOL.SaveKeywordList(item.Code, KeywordCodeList, 6);
                }
                catch
                {
                }

            }

        }
        private void ExtractKeywords(string AdsContent)
        {
            Tools tools = new Tools();
            ArrayList OneLenList = tools.GenLenKeywords(1, 2, @"(\w+)(\w+)", AdsContent);
            ArrayList TwoLenList = tools.GenLenKeywords(2, 2, @"(\w+)(\w+)", AdsContent);
            ArrayList TreeLenList = tools.GenLenKeywords(3, 1, @"(\w+)(\w+)", AdsContent);
            ArrayList FourLenList = tools.GenLenKeywords(4, 1, @"(\w+)(\w+)", AdsContent);
            List<String> FinalKeywords = new List<String>();

            string[] OneLenListArray = (String[])OneLenList.ToArray(typeof(string));
            string[] TwoLenListArray = (String[])TwoLenList.ToArray(typeof(string));
            string[] TreeLenListArray = (String[])TreeLenList.ToArray(typeof(string));
            string[] FourLenListArray = (String[])FourLenList.ToArray(typeof(string));

            IEnumerable<String> FullKeyList;
            FullKeyList = FourLenListArray.Union(TreeLenListArray).Union(TwoLenListArray).Union(OneLenListArray);
            for (int j = 0; j < FullKeyList.Count(); j++)
            {
                string CurrentKeyword = FullKeyList.ElementAt(j);
                IEnumerable<String> ContainList = FullKeyList.Where(p => p.Contains(CurrentKeyword));
                if (!CurrentKeyword.Contains(" "))
                    FinalKeywords.Add(CurrentKeyword);
                else if (ContainList.Count() == 1 || !CurrentKeyword.Contains(" "))
                    FinalKeywords.Add(ContainList.ElementAt(0));
            }
            AdvertiseKeyword = FinalKeywords;
            //return Tools.GetkeywordCodes(FinalKeywords);
        }

        protected void btnGenRelations_Click(object sender, EventArgs e)
        {
            //BOLEntityRelations EntityRelationsBOL = new BOLEntityRelations();

            //ContentsDataContext dc = new ContentsDataContext();
            //var ContentList = dc.Contents;
            //foreach (var item in ContentList)
            //{
            //    try
            //    {
            //        EntityRelationsBOL.SetRelatedEntities(item.Code, 4, 4, 3);
            //    }
            //    catch
            //    {
            //    }

            //}

            //BOLEntityRelations EntityRelationsBOL = new BOLEntityRelations();

            //ContentsDataContext dc = new ContentsDataContext();
            //var ContentList = dc.Contents;
            //foreach (var item in ContentList)
            //{
            //    try
            //    {
            //        EntityRelationsBOL.SetRelatedEntities(item.Code, 5, 4, 3);
            //        EntityRelationsBOL.SetRelatedEntities(item.Code, 5, 5, 3);
            //    }
            //    catch
            //    {
            //    }

            //}


            BOLEntityRelations EntityRelationsBOL = new BOLEntityRelations();

            ContentsDataContext dc = new ContentsDataContext();
            var ContentList = dc.Contents;
            foreach (var item in ContentList)
            {
                try
                {
                    EntityRelationsBOL.SetRelatedEntities(item.Code, 5, 6, 2);
                }
                catch
                {
                }

            }

        }

    }
}