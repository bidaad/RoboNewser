using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.SessionState;
using RoboNewser.Code.DAL;
using System.Collections.Generic;
using System.Reflection;

public class BaseBOLUsers : Users, IBaseBOL<Users>
{
    protected UsersDataContext dataContext;
    List<AccessListStruct> AccessList;
    protected string TableOrViewName = "vUsers";
    public string BaseID = "Users";
    public BaseBOLUsers()
    {
        dataContext = new UsersDataContext();

    }

    string IBaseBOL.QueryObjName
    {
        get
        {
            return TableOrViewName;
        }
        set
        {
            TableOrViewName = value;
        }
    }
    public List<WebControl> ObjectList;



    Users IBaseBOL<Users>.GetDetails(int Code)
    {
        return dataContext.Users.Single(p => p.Code.Equals(Code));
    }
    public int SaveChanges(bool IsNewRecord)
    {
        Users ObjTable;
        if (IsNewRecord)
        {
            ObjTable = new Users();
            dataContext.Users.InsertOnSubmit(ObjTable);
        }
        else
        {
            ObjTable = dataContext.Users.Single(p => p.Code.Equals(this.Code));
        }
        try
        {
            #region Save Controls

            string BaseID = this.ToString().Substring(3, this.ToString().Length - 3);
            Tools tools = new Tools();
            tools.AccessList = tools.GetAccessList(BaseID);
            foreach (WebControl wc in ObjectList)
            {
                string Property = wc.ID.Substring(3, wc.ID.Length - 3);
                PropertyInfo pi = ObjTable.GetType().GetProperty(Property);
                string FullPropName = BaseID + "." + Property;
                if (tools.HasAccess("Edit", BaseID + "." + Property))
                    pi.SetValue(ObjTable, Tools.GetControlValue(wc), new object[] { });
            }
            #endregion

            if (tools.HasAccess("Edit", "Users"))
                dataContext.SubmitChanges();
        }
        catch (Exception exp)
        {
            throw exp;
        }

        return ObjTable.Code;
    }

    public int InsertRecord()
    {
        Users ObjTable;
        ObjTable = new Users();
        ObjTable.CreateDate = DateTime.Now;
        dataContext.Users.InsertOnSubmit(ObjTable);
        try
        {
            #region Save Controls
            ObjTable.ID = ID;
            ObjTable.FirstName = FirstName;
            ObjTable.LastName = LastName;
            ObjTable.Password = Password;
            ObjTable.City = City;
            ObjTable.StateCode = StateCode;
            ObjTable.HCCountryCode = HCCountryCode;
            ObjTable.Email = Email;
            ObjTable.BirthDate = BirthDate;
            ObjTable.AutoLogin = AutoLogin;
            ObjTable.Active = Active;
            ObjTable.HCGenderCode = HCGenderCode;
            ObjTable.IAddMeAsFriend = true;
            ObjTable.ISendMessage = true;
            ObjTable.IConnectMeAsFan = true;
            ObjTable.IConfirmFriendshipReq = true;
            ObjTable.IPostMeGlobalMessage = true;
            ObjTable.IPostMePrivateMessage = true;
            ObjTable.ISuggestsFriends = true;
            ObjTable.IAcceptFriendISuggested = true;
            ObjTable.ITagsMeOnPhoto = true;
            ObjTable.ICommentOnMyPhoto = true;
            ObjTable.IInviteMeToJoinGroup = true;
            ObjTable.IRequestToJoinMyGroup = true;
            ObjTable.IInviteMeAnEvent = true;
            ObjTable.IChangeMyEventDate = true;
            ObjTable.ICommentOnMyNote = true;
            ObjTable.ICommentMyLink = true;
            ObjTable.ICommentAfterMeInLink = true;

            #endregion

            dataContext.SubmitChanges();
        }
        catch (Exception exp)
        {
            throw exp;
        }

        return ObjTable.Code;

    }

    #region IBaseBOL Members
    string IBaseBOL.EditForm
    {
        get { return "AccessLevel/EditUsers.aspx"; }
    }
    string IBaseBOL.ViewForm
    {
        get { return ""; }
    }
    string IBaseBOL.PageLable
    {
        get { return "کاربران"; }
    }
    int IBaseBOL.EditWidth
    {
        get { return 950; }
    }
    int IBaseBOL.EditHeight
    {
        get { return 700; }
    }
    DataTable IBaseBOL.GetDataSource(SearchFilterCollection sFilterCols, string SortString, int PageSize, int CurrentPage)
    {
        string WhereCond = Tools.GetCondition(sFilterCols);
        var ListResult = dataContext.ExecuteQuery<vUsers>(string.Format("exec spGetPaged '{0}','{1}','{2}','{3}',N'{4}'", TableOrViewName, SortString, PageSize, CurrentPage, WhereCond));
        DataTable dt = new Converter<vUsers>().ToDataTable(ListResult);
        return dt;
    }
    int IBaseBOL.GetCount(SearchFilterCollection sFilterCols)
    {
        int RecordCount = 1;
        string WhereCond = Tools.GetCondition(sFilterCols).Replace("''", "'");
        var ResultQuery = new DBToolsDataContext().spGetCount(TableOrViewName, WhereCond);

        RecordCount = (int)ResultQuery.ReturnValue;
        return RecordCount;
    }

    void IBaseBOL.DeleteRecord(params string[] DelParam)
    {
        Tools tools = new Tools();
        tools.AccessList = tools.GetAccessList(BaseID);

        if (tools.HasAccess("Edit", "Users"))
        {
            Users ObjTable = dataContext.Users.Single(p => p.Code.Equals(DelParam[0]));
            dataContext.Users.DeleteOnSubmit(ObjTable);
            dataContext.SubmitChanges();
        }
    }

    CellCollection IBaseBOL.GetCellCollection()
    {
        return GetCellCollection();
    }
    CellCollection IBaseBOL.GetListCellCollection()
    {
        DataCell dataCell;
        CellCollection CellCol = new CellCollection();

        dataCell = new DataCell();
        dataCell.CaptionName = "کد";
        dataCell.IsKey = true;
        dataCell.DisplayMode = DisplayModes.Hidden;
        dataCell.Align = AlignTypes.Right;
        dataCell.FieldName = "Code";
        dataCell.MaxLength = 100;
        dataCell.Width = 50;
        CellCol.Add(dataCell);

        dataCell = new DataCell("FirstName", "نام", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);

        dataCell = new DataCell("LastName", "نام خانوادگی", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);

        dataCell = new DataCell("Active", "وضعیت", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);


        return CellCol;
    }
    #endregion
    private CellCollection GetCellCollection()
    {
        DataCell dataCell;
        CellCollection CellCol = new CellCollection();

        dataCell = new DataCell();
        dataCell.CaptionName = "کد";
        dataCell.IsKey = true;
        dataCell.DisplayMode = DisplayModes.Hidden;
        dataCell.Align = AlignTypes.Right;
        dataCell.FieldName = "Code";
        dataCell.Width = 50;
        CellCol.Add(dataCell);

        dataCell = new DataCell("FirstName", "نام", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);

        dataCell = new DataCell("LastName", "نام خانوادگی", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);

        dataCell = new DataCell("Active", "وضعیت", AlignTypes.Right, 200);
        dataCell.IsListTitle = true;
        dataCell.DisplayMode = DisplayModes.Visible;
        CellCol.Add(dataCell);


        return CellCol;
    }
}
