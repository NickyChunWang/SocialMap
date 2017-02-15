﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace myTaiwanTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class myTaiwanEntities : DbContext
    {
        public myTaiwanEntities()
            : base("name=myTaiwanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Sign> Signs { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
    
        public virtual ObjectResult<sp_BrowseText_Result> sp_BrowseText(Nullable<int> friendID)
        {
            var friendIDParameter = friendID.HasValue ?
                new ObjectParameter("friendID", friendID) :
                new ObjectParameter("friendID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BrowseText_Result>("sp_BrowseText", friendIDParameter);
        }
    
        public virtual int sp_setCoverUrl(string coverUrl, Nullable<int> userID)
        {
            var coverUrlParameter = coverUrl != null ?
                new ObjectParameter("CoverUrl", coverUrl) :
                new ObjectParameter("CoverUrl", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_setCoverUrl", coverUrlParameter, userIDParameter);
        }
    
        public virtual int sp_setFaceUrl(string faceUrl, Nullable<int> userID)
        {
            var faceUrlParameter = faceUrl != null ?
                new ObjectParameter("FaceUrl", faceUrl) :
                new ObjectParameter("FaceUrl", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_setFaceUrl", faceUrlParameter, userIDParameter);
        }
    
        public virtual ObjectResult<sp_BrowseTextbyCounty_Result> sp_BrowseTextbyCounty(Nullable<int> friendID, Nullable<int> location)
        {
            var friendIDParameter = friendID.HasValue ?
                new ObjectParameter("friendID", friendID) :
                new ObjectParameter("friendID", typeof(int));
    
            var locationParameter = location.HasValue ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BrowseTextbyCounty_Result>("sp_BrowseTextbyCounty", friendIDParameter, locationParameter);
        }
    }
}
