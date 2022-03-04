using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListById(int id);
        void ContentAdd(Content content);
        Content GetById(int id); //tek değer döndürür
        void ContentDelete(Content content);
        void ContentUpdate(Content content);

    }
}
