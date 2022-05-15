using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {//burası business tarafı kontrolleri yapılacağı yer.
        //20 karakteri geçmesin vb...
        //ürün giren kişi yetkili olmalı vb..
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T GetById(int id);
    }
}
