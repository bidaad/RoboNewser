using System.Web.UI;
using System.Web.UI.Adapters;
using System.Web.UI.WebControls; 
/// <summary>
/// Summary description for HyperLinkControlAdapter
/// </summary>
public class HyperLinkControlAdapter : ControlAdapter 
{
    protected override void Render(HtmlTextWriter writer)
    {
        HyperLink hl = this.Control as HyperLink;
        if (hl == null)
        {
            base.Render(writer);
            return;
        }

        string imageUrl = hl.ImageUrl;
        if (imageUrl.Length > 0)
        {
            hl.RenderBeginTag(writer);

            Image image = new Image();
            image.ImageUrl = imageUrl;

            imageUrl = hl.ToolTip;
            if (imageUrl.Length != 0)
            {
                image.ToolTip = imageUrl;
            }

            imageUrl = hl.Text;
            if (imageUrl.Length != 0)
            {
                image.AlternateText = imageUrl;
            }

            image.RenderControl(writer);

            hl.RenderEndTag(writer);
        }
        else
        {
            base.Render(writer);
        }
    } 
}