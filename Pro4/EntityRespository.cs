using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro4
{
    public class EntityRespository<T> where T : class
    {
      private List<T> items = new List<T>();
      public void Add(T item){
        items.Add(item);
      }  
      public List<T> GetAll(){
        return items;
      }
      public T GetById(Func<T, bool>predicate){
        return items.FirstOrDefault(predicate);
      }
      public void Remove(T item){
        items.Remove(item);
      }
    }
}