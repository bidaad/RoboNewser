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
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using RoboNewser.Code.DAL;


public class BOLEntityRelations : BaseBOLEntityRelations, IBaseBOL<EntityRelations>
{

    public void SetRelatedEntities(int EntityCode, int HCEntityTypeCode, int HCRelatedEntityTypeCode, int MinMatualCount)
    {

        EntityRelationsDataContext datacontext;
        EntityRelationsDataContext datacontextInner;
        datacontext = new EntityRelationsDataContext();
        var ResultList = datacontext.spSetRelatedEntities(EntityCode, HCEntityTypeCode, HCRelatedEntityTypeCode, MinMatualCount);


    }
    public IList CheckBusinessRules()
    {
        var messages = new List<string>();

        return messages;
    }
    public void SetAllRelations(int ReturnCode, int HCEntityCode, int MinMatualCount)
    {
        SetRelatedEntities(ReturnCode, HCEntityCode, 1, MinMatualCount); //Get Related News
        SetRelatedEntities(ReturnCode, HCEntityCode, 2, MinMatualCount); //Get Related Advertises
        SetRelatedEntities(ReturnCode, HCEntityCode, 3, MinMatualCount); //Get Related Sites
        SetRelatedEntities(ReturnCode, HCEntityCode, 4, MinMatualCount); //Get Related Contents

    }

    public void DeleteReleatedEntity(int code, int relatedCode, string entityName)
    {
        var datacontext = new EntityRelationsDataContext();
        EntityRelations relation = null;
        switch (entityName)
        {
            default:
                throw new Exception("No related entity found.");
        }

        if (relation != null)
        {
            datacontext.EntityRelations.DeleteOnSubmit(relation);
            datacontext.SubmitChanges();
        }
    }
}
