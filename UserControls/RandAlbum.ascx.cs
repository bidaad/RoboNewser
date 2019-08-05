using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RoboNewser.Code.DAL;

public partial class UserControls_RandAlbum : System.Web.UI.UserControl
{
    public int AlbumCode;
    protected int GetRandRow(int Count)
    {
        Random rnd = new Random();
        double val = rnd.NextDouble();
        int RandVal = Convert.ToInt32((Count * val));
        if (RandVal > 0)
            RandVal--;
        return RandVal;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //MusicsDataContext dc = new MusicsDataContext();
        //IQueryable<ArtistAlbums> AlbumList = dc.ArtistAlbums;
        //int AlbumCount = AlbumList.Count();
        //if (AlbumCount > 0)
        //{
        //    int RandVal = GetRandRow(AlbumCount);
        //    string FileName;
        //    ArtistAlbums CurAlbum = (AlbumList.Skip(RandVal).Take(1)).Single();
        //    Artists CurArtist = dc.Artists.SingleOrDefault(p => p.Code.Equals(CurAlbum.ArtistCode));
        //    AlbumCode = CurAlbum.Code;
        //    if(CurAlbum.PicFile != null)
        //        imgAlbum.ImageUrl = "~/Files/ArtistAlbums/" + CurAlbum.PicFile;
        //    else
        //        imgAlbum.ImageUrl = "~/images/Music.jpg";
        //    imgAlbum.ToolTip = CurAlbum.Title;
        //    hplTitle.Text = CurAlbum.Title + "(" + CurArtist.FullName + ")";

        //}

    }
}
