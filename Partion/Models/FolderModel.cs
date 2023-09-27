using Partion.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partion.Models
{
    public class FolderModel
    {
        public FolderModel()
        {
            Child= new List<FolderModel>();
        }
        public FolderModel(Folder obj)
        {
            this.Id = obj.Id;
            this.Name = obj.Name;
            this.ParentId = obj.ParentId;
            this.IsOpen = obj.IsOpen;
            this.Child = obj.Folder1.Select(c=> new FolderModel(c)).ToList();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsOpen { get; set; }
        public Nullable<int> ParentId { get; set; }
        public virtual List<FolderModel> Child { get; set; }
    }
}